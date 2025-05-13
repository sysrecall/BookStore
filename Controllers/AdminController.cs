using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Validation;
using BookStore.Models;
using BookStore.DAL;
using System.Net;


namespace BookStore.Controllers
{
    public class AdminController : Controller
    {
        public BookStoreContext _AdminDb;

        public AdminController()
        {
            _AdminDb = new BookStoreContext();
        }
        // GET: Admin
        public ActionResult Index()
        {
            var data = _AdminDb.User.ToList();

            return View(data);
        }
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
                    return RedirectToAction("Index", "Home");
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



        //User related works
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

            return View(user);
        }
        public ActionResult DeleteUser(int? id)
        {
              User user = _AdminDb.User.Find(id);

            
                _AdminDb.User.Remove(user);
                _AdminDb.SaveChanges();
                TempData["MsgRem"] = "User information removed successfully";
            return RedirectToAction("Index");
          
           
        }




        public ActionResult Report()
        {
            return View();
        }



    }
}
