using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore.DAL;
using BookStore.Models.Store;
using BookStore.ViewModels;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private BookStoreContext db;
        public HomeController()
        {
            db = new BookStoreContext();
        }
        public ActionResult Index(HomeIndexViewModel model)
        {
            var books = model.SearchQuery != null 
                ? db.Book
                    .Where(x => x.Title.ToLower().Contains(model.SearchQuery.ToLower()))
                    .Cast<Book>()
                    .ToList()
                : db.Book.ToList();

            if (model.SelectedCategory != null)
                books = books.Where(x => x.Category == model.SelectedCategory).ToList();

            Cart cart = null;
            if (Session["UserID"] != null)
            {
                int _id = Convert.ToInt32(Session["UserID"]);
                cart = db.Cart.Include(c => c.Books).FirstOrDefault(x => x.UserID == _id);
            }

            var bookCards = books.Select(book => new BookCardViewModel
            {
                Book = book,
                IsInCart = cart?.Books != null &&
                           cart.UserID == Convert.ToInt32(Session["UserID"]) && 
                           cart.Books.Contains(book)
            }).ToList();

            var homeIndexViewModel = new HomeIndexViewModel()
            {
                BookCards = bookCards,
                Categories = Enum.GetValues(typeof(Category)).Cast<Category>().ToList(),
                CurrentPage = model.CurrentPage,
                SelectedCategory = model.SelectedCategory,
                SearchQuery = model.SearchQuery,
                TotalPages = 10,
            };
            
            return View(homeIndexViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
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