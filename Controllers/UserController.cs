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
    public class UserController : Controller
    {
        public BookStoreContext _UserDb;
        public UserController()
        {
            _UserDb = new BookStoreContext();
        }
        // GET: User
        public ActionResult Index()
        {
            var users = new List<User>
                    {
                        new User { Username = "johndoe", PasswordHash = "123" },
                        new User { Username = "dsa", PasswordHash = "123" },
                        new User { Username = "asdafa", PasswordHash = "123" },
                        new User { Username = "asdvvv", PasswordHash = "123" },
                        new User { Username = "zxczv", PasswordHash = "123" }
                    };
            users.ForEach(u => _UserDb.Users.Add(u));
            _UserDb.SaveChanges();

            return View(users);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                var existingUser = _UserDb.Users.FirstOrDefault(u => u.Username == user.Username && u.PasswordHash == user.PasswordHash);
                if (existingUser != null)
                {
                    Session["UserId"] = existingUser.ID;
                    Session["Username"] = existingUser.Username;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                }
            }
            return View(user);
        }
    }
}