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

            if (model.SelectedCategory != null)
            {
                booksQuery = booksQuery.Where(x => x.Category == model.SelectedCategory);
            }

            int pageSize = 20;
            int currentPage = model.CurrentPage > 0 ? model.CurrentPage : 1;

            int totalBooks = booksQuery.Count();
            int totalPages = (int)Math.Ceiling((double)totalBooks / pageSize);

            var pagedBooks = booksQuery
                .OrderBy(b => b.Title)
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            Dictionary<int, int> bookQuantities = new Dictionary<int, int>();
            User user = null;
            int userId = 0;

            if (Session["UserID"] != null && int.TryParse(Session["UserID"].ToString(), out userId))
            {
                user = db.User.Include(u => u.Books).FirstOrDefault(u => u.ID == userId);
                var cart = db.Cart
                    .Include(c => c.CartItems.Select(ci => ci.Book))
                    .FirstOrDefault(c => c.UserID == userId);

                if (cart?.CartItems != null)
                {
                    bookQuantities = cart.CartItems.ToDictionary(ci => ci.BookID, ci => ci.Quantity);
                }
            }
            else
            {
                // Guest user: get guest ID cookie
                var guestId = Request.Cookies["GuestID"]?.Value;
                if (!string.IsNullOrEmpty(guestId))
                {
                    var guestCart = db.Cart
                        .Include(c => c.CartItems.Select(ci => ci.Book))
                        .FirstOrDefault(c => c.GuestID == guestId);

                    if (guestCart?.CartItems != null)
                    {
                        bookQuantities = guestCart.CartItems.ToDictionary(ci => ci.BookID, ci => ci.Quantity);
                    }
                }
            }

            var bookCards = pagedBooks.Select(book => new BookCardViewModel
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
                CurrentPage = currentPage,
                SelectedCategory = model.SelectedCategory,
                SearchQuery = model.SearchQuery,
                TotalPages = totalPages,
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