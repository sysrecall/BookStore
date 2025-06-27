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
using BookStore.Models.Store;
using BookStore.ViewModels;

namespace BookStore.Controllers.Store
{
    public class BookController : Controller
    {
        private BookStoreContext db = new BookStoreContext();

        [Route("Book/{BookID:int}")]
        public ActionResult Index(int? BookID, BookType? selectedBookType)
        {
            if (BookID == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var book = db.Book
                .Include(b => b.BookInfo)
                .Include(b => b.BookInfo.AvailableTypes)
                .Include(b => b.BookImages)
                .FirstOrDefault(b => b.ID == BookID);

            if (book == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var recommendedBooks = db.Book
                .Include(b => b.BookImages)
                .Where(b => b.Category == book.Category && b.ID != book.ID)
                .Take(10)
                .ToList();

            int bookQuantity = 0;
            User user = null;

            if (Session["UserID"] != null)
            {
               int userId = Convert.ToInt32(Session["UserID"]);
                
                user = db.User.Include(u => u.Books).FirstOrDefault(u => u.ID == userId);
                var cart = db.Cart
                    .Include(c => c.CartItems.Select(ci => ci.Book))
                    .FirstOrDefault(c => c.UserID == userId);

                if (cart?.CartItems != null)
                {
                    bookQuantity = cart.CartItems
                        .FirstOrDefault(c => c.BookID == book.ID)?.Quantity ?? 0;
                } 
            }
            else
            {
                var guestId = Request.Cookies["GuestID"]?.Value;
                if (!string.IsNullOrEmpty(guestId))
                {
                    var guestCart = db.Cart
                        .Include(c => c.CartItems.Select(ci => ci.Book))
                        .FirstOrDefault(c => c.GuestID == guestId);

                    if (guestCart?.CartItems != null)
                    {
                        bookQuantity = guestCart.CartItems
                            .FirstOrDefault(c => c.BookID == book.ID)?.Quantity ?? 0;
                    }
                } 
            }

            var bookCardViewModel = new BookCardViewModel
            {
                Book = book,
                SelectedBookType = selectedBookType,
                IsInCart = bookQuantity > 0,
                IsOwned = user?.Books.Contains(book) ?? false,
                IsInStock = db.Inventory.Find(BookID)?.AmountInStock > 0,
                RecommendedBooks = recommendedBooks,
                QuantityInCart = bookQuantity,
            };
            
            return View(bookCardViewModel);
        }

 
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Book.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                db.Book.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(book);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Book.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        [HttpPost]
        public ActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(book);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Book.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Book book = db.Book.Find(id);
            db.Book.Remove(book);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Read(int bookId)
        {
            if (Session["UserID"] == null)
            {
                return RedirectToAction("Index", "Book");
            }
            
            int userId = Convert.ToInt32(Session["UserID"]);
            var user = db.User.Include("Books").FirstOrDefault(u => u.ID == userId);
            if (user == null)
                return RedirectToAction("Login", "Account");
                
            var book = db.Book.FirstOrDefault(b => b.ID == bookId);
            if (book == null)
                return HttpNotFound();

            if (!user.Books.Contains(book))
                return RedirectToAction("Index", "Book", new { BookId = bookId });
            
            return View(book);
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
