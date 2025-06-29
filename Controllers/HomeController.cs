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

        public ActionResult Index()
        {
            var booksQuery = db.Book
                .Include(b => b.BookInfo)
                .Include(b => b.BookImages);

            var pagedBooks = booksQuery
                .OrderBy(b => b.Title)
                .Take(6)
                .ToList();

            var bookCards = pagedBooks
                .Select(book => new BookCardViewModel { Book = book })
                .ToList();

            var homeIndexViewModel = new HomeIndexViewModel
            {
                BookCards = bookCards,
                Categories = Enum.GetValues(typeof(Category)).Cast<Category>().ToList(),
                CurrentPage = 1,
                SelectedCategory = null,
                SearchQuery = null,
                TotalPages = 1
            };

            return View(homeIndexViewModel);
        }

        
        public ActionResult Browse(HomeIndexViewModel model)
        {
            var booksQuery = db.Book
                .Include(b => b.BookInfo)
                .Include(b => b.BookImages)
                .AsQueryable();

            if (!string.IsNullOrEmpty(model.SearchQuery))
            {
                string searchLower = model.SearchQuery.ToLower();
                booksQuery = booksQuery.Where(x => x.Title.ToLower().Contains(searchLower));
            }

            if (model.SelectedCategory != null)
            {
                booksQuery = booksQuery
                    .Where(x => x.Category == model.SelectedCategory)
                    .OrderBy(b => b.Rating);
            }

            int pageSize = 20;
            int currentPage = model.CurrentPage > 0 ? model.CurrentPage : 1;

            int totalBooks = booksQuery.Count();
            int totalPages = totalBooks / pageSize;

            var pagedBooks = booksQuery
                .OrderBy(b => b.Title)
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var bookCards = pagedBooks
                .Select(book => new BookCardViewModel { Book = book, })
                .ToList(); 
            
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

        public ActionResult Library(string searchQuery, Category? selectedCategory, int page = 1)
        {
            if (Session["UserID"] == null)
                return RedirectToAction("Login", "Account");

            int PageSize = 10;
            int userId = Convert.ToInt32(Session["UserID"]);
            var user = db.User.Include("Books").FirstOrDefault(u => u.ID == userId);

            if (user == null)
                return RedirectToAction("Login", "Account");

            IEnumerable<Book> books = user.Books;

            if (!string.IsNullOrEmpty(searchQuery))
            {
                var query = searchQuery.ToLower();
                books = books.Where(b => b.Title.ToLower().Contains(query));
            }

            if (selectedCategory != null)
            {
                books = books.Where(b => b.Category == selectedCategory);
            }

            var totalBooks = books.Count();
            var totalPages = (int)Math.Ceiling((double)totalBooks / PageSize);

            books = books.Skip((page - 1) * PageSize).Take(PageSize);

            var model = new LibraryViewModel
            {
                Books = books.ToList(),
                SearchQuery = searchQuery,
                SelectedCategory = selectedCategory,
                Categories = Enum.GetValues(typeof(Category)).Cast<Category>().ToList(),
                CurrentPage = page,
                TotalPages = totalPages
            };

            return View(model);
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