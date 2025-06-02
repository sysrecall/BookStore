using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Validation;
using BookStore.Models;
using BookStore.DAL;
using System.Net;
using BookStore.Models.Store;
using BookStore.ViewModels;




namespace BookStore.Controllers
{
    public class AdminController : Controller
    {
        public BookStoreContext _AdminDb;

        public AdminController()
        {
            _AdminDb = new BookStoreContext();
        }

        

        //Admin Related works here
        public ActionResult Login()
        {
              return View();
        }
        [HttpPost]
        public ActionResult Login(Admin admin)
        {

            if (ModelState.IsValid)
            {
                var existingAdmin = _AdminDb.Admin.FirstOrDefault(a => a.Email == admin.Email && a.Password == admin.Password);
                if (existingAdmin != null)
                {
                    Session["AdminId"] = existingAdmin.Id;
                    Session["AdminEmail"] = existingAdmin.Email;
                    return RedirectToAction("DashBoard");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                }
                ViewBag.admin = existingAdmin;

            }
            return View(admin);
        }

        public ActionResult SignUp()
        {
            var admin = new Admin
            {
                Department = "Administration",
                Position = "Admin"
            };

            return View(admin);
        }

        [HttpPost]
        public ActionResult SignUp(Admin admin)
        {
            if (ModelState.IsValid)
            {
                _AdminDb.Admin.Add(admin);
                _AdminDb.SaveChanges();
                return RedirectToAction("Login");

            }
            return View(admin);
        }

        public ActionResult AdminProfile()
        {
            if (Session["AdminId"] != null)
            {
                int adminId = Convert.ToInt32(Session["AdminId"]);
                Admin admin = _AdminDb.Admin.FirstOrDefault(a => a.Id == adminId);

                if (admin != null)
                {
                    return View(admin);
                }
            }

            return RedirectToAction("Login");
        }



        //User related works
        public ActionResult Index()
        {
            if (Session["AdminId"] == null)
            {
                return RedirectToAction("Login");
            }
            var data = _AdminDb.User.ToList();

            return View(data);
        }
        [HttpPost]
        public ActionResult AddUser(User user)
        {
            if (ModelState.IsValid)
            {
                _AdminDb.User.Add(user);
                _AdminDb.SaveChanges();
                TempData["MsgAddUser"] = "User added successfully";
                return RedirectToAction("Index");
            }
            return View("AddUser", user);
        }
        public ActionResult DeleteUser(int id)
        {
            var user = _AdminDb.User.Find(id);
            if (user != null)
            {
                _AdminDb.User.Remove(user);
                _AdminDb.SaveChanges();
                TempData["MsgRem"] = "User deleted successfully";
            }
            return RedirectToAction("Index");
        }

        //Book related works here
        public ActionResult BookIndex()
        {
            if (Session["AdminId"] == null)
            {
                return RedirectToAction("Login");
            }

            var data = _AdminDb.Books.ToList();
            return View(data);
        }

        [HttpPost]
        public ActionResult AddBooks(Book book)
        {
            if (ModelState.IsValid)
            {
                _AdminDb.Books.Add(book);
                _AdminDb.SaveChanges();
                return RedirectToAction("BookIndex");
            }

            return View(book);
        }

        public ActionResult DeleteBook(int id)
        {
            Book book = _AdminDb.Books.Find(id);
            if (book != null)
            {
                _AdminDb.Books.Remove(book);
                _AdminDb.SaveChanges();
            }
            return RedirectToAction("BookIndex");
        }


        public ActionResult Report()
        {
            if (Session["AdminId"] == null)
            {
                return RedirectToAction("Login");
            }

            var books = _AdminDb.Books.ToList();

            var reportViewModel = new ReportViewModel
            {
                Books = books,
                BookCount = books.Count,
                SalesByCategory = "Category data here",
                TopSellingBooks = "Top selling books data here",
                TotalSales = "Total sales data here"
            };

            return View(reportViewModel);
        }



        public ActionResult DashBoard()
        {
            if (Session["AdminID"] == null)
            {
                return RedirectToAction("Login");
            }

            return View();
        }



    }
}
