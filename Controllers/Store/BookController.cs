using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BookStore.DAL;
using BookStore.Models.Store;
using BookStore.ViewModels;

namespace BookStore.Controllers.Store
{
    public class BookController : Controller
    {
        private BookStoreContext db = new BookStoreContext();

        [Route("Book/{BookID:int}")]
        public ActionResult Index(int? BookID)
        {
           if (BookID == null)
           {
               return RedirectToAction("Index", "Home");
           }

           var bookCardViewModel = new BookCardViewModel();
           
           var book = db.Book.FirstOrDefault(b => b.ID == BookID);
           if (book == null) return RedirectToAction("Index", "Home");
           
           bookCardViewModel.Book = book;
           
           if (Session["UserID"] == null) return View(bookCardViewModel);
           var UserID = Convert.ToInt32(Session["UserID"]);
           
           var _user = db.User.FirstOrDefault(x => x.ID == UserID);
           if (_user == null) return View(bookCardViewModel);
           
           var cart = db.Cart.Include(c => c.Books).FirstOrDefault(x => x.UserID == UserID);
           if (cart?.Books != null && cart.Books.Contains(book))
           {
               bookCardViewModel.IsInCart = true;
           }
           
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
