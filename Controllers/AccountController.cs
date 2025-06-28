using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;
using BookStore.DAL;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class AccountController : Controller
    {
        BookStoreContext db;
        public AccountController()
        {
           db = new BookStoreContext();
        }

       
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Account account)
        {
            if (ModelState.IsValid)
            {
                var acc = db.Account.FirstOrDefault(a => a.Username == account.Username);

                if (acc != null)
                {
                    //TODO
                    // verify hash 
                    if (acc.PasswordHash == account.PasswordHash)
                    {
                        switch (acc.Role)
                        {
                            case "Admin":
                                var admin = db.Admin.FirstOrDefault(a => a.AccountID == acc.ID);
                                if (admin == null)
                                {
                                    return RedirectToAction("Login", "Account");
                                }
                                Session["AdminID"] = admin.Id;
                                return RedirectToAction("DashBoard", "Admin");
                            case "User":
                                var user = db.User.Include("Account").FirstOrDefault(u => u.AccountID == acc.ID);
                                if (user == null)
                                {
                                    return RedirectToAction("Login", "Account");
                                }
                                Session["UserID"] = user.ID;
                                return RedirectToAction("Browse", "Home");
                            default:
                                return RedirectToAction("Login", "Account");
                        }
                    }
                }
            }
            
            ModelState.AddModelError("", "Invalid username or password.");

            return View(account);
        }
    }
}