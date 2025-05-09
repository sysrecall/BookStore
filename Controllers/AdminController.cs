using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Validation;
using BookStore.Models;
using BookStore.DAL;

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
            return View();
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
            }
            return View(admin);
        }

        public ActionResult SignUp()
        {
            return View();
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
    }
}
