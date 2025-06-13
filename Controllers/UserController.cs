using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BookStore.DAL;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class UserController : Controller
    {
        private BookStoreContext db = new BookStoreContext();

        public ActionResult Index()
        {
            if (Session["UserID"] == null)
                return RedirectToAction("Login", "Account");
            
            var userId = Convert.ToInt32(Session["UserID"]); // or however you store user login
            var user = db.User.Include("Books").FirstOrDefault(u => u.ID == userId);
            return View(user);
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.User.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                user.Account.Role = "User";
                db.User.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login", "Account");
            }

            return View(user);
        }
        
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.User.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.User.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.User.Include("Account").FirstOrDefault(u => u.ID == id);
            if (user != null)
            {
                Account account = user.Account;
                if (account != null)
                    db.Account.Remove(account);
                
                db.User.Remove(user);
                db.SaveChanges();
            }
            return RedirectToAction("Logout");
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            Session.Clear();
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateUser(User user)
        {
            if (!ModelState.IsValid)
            {
                TempData["Message"] = "Invalid data. Please check your input.";
                TempData["MessageType"] = "danger";
                return RedirectToAction("Index");
            }
            var _user = db.User.Find(user.ID);
            if (_user != null)
            {
                _user.FullName = user.FullName;
                _user.Email = user.Email;
                _user.ShippingAddress = user.ShippingAddress;
                _user.BillingAddress = user.BillingAddress;
                db.SaveChanges();
                
                TempData["Message"] = "Your account settings have been updated successfully.";
                TempData["MessageType"] = "success";
            }
            else
            {
                TempData["Message"] = "User not found.";
                TempData["MessageType"] = "danger";
            }
            
            return RedirectToAction("Index");
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult ChangePassword(int? id, string currentPassword, string newPassword)
        {
           if (id == null)
           {
               TempData["Message"] = "User id cannot be empty.";
               TempData["MessageType"] = "danger";
               return RedirectToAction("Index");
           }

           if (newPassword.Length < 8)
           {
               TempData["Message"] = "Password must be greater than 8 characters.";
               TempData["MessageType"] = "warning";
               return RedirectToAction("Index");
           }
           
           var user = db.User.Find(id);
           if (user == null)
           {
               TempData["Message"] = "Invalid user.";
               TempData["MessageType"] = "danger";
               return RedirectToAction("Index");
           }
           
           var account = db.Account.FirstOrDefault(a => a.ID == user.AccountID);
           if (account == null)
           {
               TempData["Message"] = "No account found.";
               TempData["MessageType"] = "danger";
               return RedirectToAction("Index");
           }

           if (account.PasswordHash != currentPassword)
           {
               TempData["Message"] = "Invalid Current Password";
               TempData["MessageType"] = "danger";
               return RedirectToAction("Index");
           }
           
           account.PasswordHash = newPassword;
           db.SaveChanges();
           TempData["Message"] = "Successfully Updated the Password";
           TempData["MessageType"] = "success";
           
           return Redirect("/User/Index#password");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
