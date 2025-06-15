using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore.DAL;
using BookStore.Models;
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
            var booksQuery = db.Book.AsQueryable();

            if (!string.IsNullOrEmpty(model.SearchQuery))
            {
                string searchLower = model.SearchQuery.ToLower();
                booksQuery = booksQuery.Where(x => x.Title.ToLower().Contains(searchLower));
            }

            var books = booksQuery.ToList();

            if (model.SelectedCategory != null)
            {
                books = books.Where(x => x.Category == model.SelectedCategory).ToList();
            }

            Cart cart = null;
            Dictionary<int, int> bookQuantities = new Dictionary<int, int>(); // BookID -> Quantity
            
            int userId = Convert.ToInt32(Session["UserID"]);
            User user = null;

            if (Session["UserID"] != null)
            {
                user = db.User.Include("Books").FirstOrDefault(u => u.ID == userId);
                cart = db.Cart
                    .Include(c => c.CartItems.Select(ci => ci.Book))
                    .FirstOrDefault(x => x.UserID == userId);

                if (cart?.CartItems != null)
                {
                    bookQuantities = cart.CartItems.ToDictionary(ci => ci.BookID, ci => ci.Quantity);
                }
            }

            var bookCards = books.Select(book => new BookCardViewModel
            {
                Book = book,
                QuantityInCart = bookQuantities.ContainsKey(book.ID) ? bookQuantities[book.ID] : 0,
                IsInCart = bookQuantities.ContainsKey(book.ID),
                IsOwned = user?.Books.Contains(book) ?? false
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