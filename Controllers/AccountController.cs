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
                                Session["AdminID"] = acc.ID;
                                return RedirectToAction("DashBoard", "Admin");
                            case "User":
                                Session["UserID"] = acc.ID;
                                return RedirectToAction("Index", "Home");
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