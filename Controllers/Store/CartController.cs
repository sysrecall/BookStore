using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BookStore.DAL;
using BookStore.Models;
using BookStore.Models.Store;
using System.Data.Entity;
namespace BookStore.Controllers.Store
{
    public class CartController : Controller
    {
        private BookStoreContext db;
        public CartController()
        {
            db = new BookStoreContext();
        }
        
        [HttpPost]
        public ActionResult AddBook(int? UserID, int? BookID)
        {
            if (UserID == null)
            {
                return RedirectToAction("Login", "Account");
            }

            if (BookID == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var book = db.Book.FirstOrDefault(b => b.ID == BookID);
            if (book != null)
            {
                var _user = db.User.FirstOrDefault(x => x.ID == UserID);
                if (_user != null)
                {
                    var cart = db.Cart.Include(c => c.Books).FirstOrDefault(x => x.UserID == UserID);
                    if (cart?.Books  != null)
                    {
                        cart.Books.Add(book);
                    }
                    else
                    {
                        cart = new Cart { User = _user, Books = new List<Book> { book } };
                        db.Cart.Add(cart);
                    }
                }

                db.SaveChanges();
            }

            if (Request.UrlReferrer != null)
                return Redirect(Request.UrlReferrer.ToString());
            
            return RedirectToAction("Index", "Home");
        }
        
        [HttpPost]
        public ActionResult RemoveBook(int? UserID, int? BookID)
        {
            if (UserID == null)
            {
                return RedirectToAction("Login", "Account");
            }

            if (BookID == null)
            {
                return RedirectToAction("Index", "Home");
            }
            
            var book = db.Book.FirstOrDefault(b => b.ID == BookID);
            if (book != null)
            {
                var _user = db.User.FirstOrDefault(x => x.ID == UserID);
                if (_user != null)
                {
                    var cart = db.Cart.Include(c => c.Books).FirstOrDefault(x => x.UserID == UserID);
                    if (cart != null)
                    {
                        cart.Books.Remove(book);
                    }
                }
                db.SaveChanges();
            }
            
            if (Request.UrlReferrer != null)
                return Redirect(Request.UrlReferrer.ToString());
            
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult DeleteCart(int UserID)
        {
            if (ModelState.IsValid)
            {
                var _user = db.User.FirstOrDefault(x => x.ID == UserID);
                if (_user != null)
                {
                    db.Cart.Where(x => x.UserID == UserID).ToList().ForEach(x => db.Cart.Remove(x));
                }
                db.SaveChanges();
            }
            
            return RedirectToAction("Index", "Home");
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