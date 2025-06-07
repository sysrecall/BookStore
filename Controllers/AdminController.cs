using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Validation;
using BookStore.Models;
using BookStore.DAL;
using System.Net;
using BookStore.Models.Store;
using BookStore.ViewModels;
using System.IO;




namespace BookStore.Controllers
{
    public class AdminController : Controller
    {
        public BookStoreContext _AdminDb;

        public AdminController()
        {
            _AdminDb = new BookStoreContext();
        }


        //=======================
        //Admin Related works here
        //=======================
        public ActionResult Login()
        {
              return View();
        }
        [HttpPost]
        public ActionResult Login(Admin admin)
        {

            if (ModelState.IsValid)
            {
                var existingAdmin = _AdminDb.Admin.FirstOrDefault(a => a.Email == admin.Email && a.Password == admin.Password);
                if (existingAdmin != null)
                {
                    Session["AdminID"] = existingAdmin.Id;
                    Session["AdminEmail"] = existingAdmin.Email;
                    return RedirectToAction("DashBoard");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                }
                ViewBag.admin = existingAdmin;

            }
            return View(admin);
        }

        public ActionResult SignUp()
        {
            var admin = new Admin
            {
                Department = "Administration",
                Position = "Admin"
            };

            return View(admin);
        }

        [HttpPost]
        public ActionResult SignUp(Admin admin)
        {
            if (ModelState.IsValid)
            {
                _AdminDb.Admin.Add(admin);
                _AdminDb.SaveChanges();
                return RedirectToAction("Login", "Account");

            }
            return View(admin);
        }

        public ActionResult AdminProfile()
        {
            if (Session["AdminID"] != null)
            {
                int adminId = Convert.ToInt32(Session["AdminID"]);
                Admin admin = _AdminDb.Admin.FirstOrDefault(a => a.Id == adminId);

                if (admin != null)
                {
                    return View(admin);
                }
            }

            return RedirectToAction("Login", "Account");
        }

        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Login", "Account");
        }


        //=======================
        //User related works
        //=======================
        public ActionResult Index()
        {
            if (Session["AdminID"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            var data = _AdminDb.User.ToList();

            return View(data);
        }
        //[HttpPost]
        //public ActionResult AddUser(User user)
        //{
        //    if (Session["AdminID"] == null)
        //    {
        //        return RedirectToAction("Login", "Account");
        //    }
        //    if (ModelState.IsValid)
        //    {
        //        _AdminDb.User.Add(user);
        //        _AdminDb.SaveChanges();
        //        TempData["MsgAddUser"] = "User added successfully";
        //        return RedirectToAction("Index");
        //    }
        //    return View("AddUser", user);
        //}
        [HttpPost]
        public ActionResult AddUser(User user, string PasswordHash, string Role = "User")
        {
            if (Session["AdminID"] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            if (ModelState.IsValid)
            {
                var account = new Account
                {
                    Username = user.Account.Username,
                    PasswordHash = PasswordHash,
                    Role = Role
                };

              
                    _AdminDb.Account.Add(account);
                    _AdminDb.SaveChanges();

                    user.AccountID = account.ID;
                    user.Account = account;

                    _AdminDb.User.Add(user);
                    _AdminDb.SaveChanges();

                    TempData["MsgAddUser"] = "User added successfully";
                    return RedirectToAction("Index");
               
            }

            return View("AddUser", user);
        }



        public ActionResult DeleteUser(int id)
        {
            var user = _AdminDb.User.Find(id);
            if (user != null)
            {
                _AdminDb.User.Remove(user);
                _AdminDb.SaveChanges();
                TempData["MsgRem"] = "User deleted successfully";
            }
            return RedirectToAction("Index");
        }


        public ActionResult EditUser(int id)
        {
            var user = _AdminDb.User.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }

            var viewModel = new User
            {
                ID = user.ID,
                FullName = user.FullName,
                Email = user.Email
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult EditUser(User model)
        {
            if (ModelState.IsValid)
            {
                var user = _AdminDb.User.Find(model.ID);
                if (user != null)
                {
                    if (user.Account != null)
                    {
                        user.Account.Username = model.Account.Username; // ✅ Update username via Account
                    }

                    user.FullName = model.FullName;
                    user.Email = model.Email;

                    _AdminDb.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return View(model);
        }



        //=======================
        //Book related works here
        //=======================
        public ActionResult BookIndex()
        {
            if (Session["AdminID"] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var data = _AdminDb.Book.ToList();
            return View(data);
        }

        //[HttpPost]
        //public ActionResult AddBooks(Book book)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _AdminDb.Book.Add(book);
        //        _AdminDb.SaveChanges();
        //        return RedirectToAction("BookIndex");
        //    }

        //    return View(book);
        //}
        [HttpPost]
        public ActionResult AddBooks(Book book, HttpPostedFileBase image)
        {
            if (ModelState.IsValid)
            {
                if (image != null && image.ContentLength > 0)
                {
                    string folderPath = Server.MapPath("~/Books/cover/");
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(image.FileName);
                    string filePath = Path.Combine(folderPath, uniqueFileName);

                    image.SaveAs(filePath);
                    book.BookCoverImages = new List<BookCoverImage>{
                new BookCoverImage
                {
                    ImageURL = Url.Content("~/Books/cover/" + uniqueFileName)
                }};

                }

                _AdminDb.Book.Add(book);
                _AdminDb.SaveChanges();
                return RedirectToAction("BookIndex");
            }

            return View(book);
        }





        public ActionResult EditBook(int id)
        {
            var book = _AdminDb.Book.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }

            return View(book);
        }

      
        [HttpPost]
        public ActionResult EditBook(Book model)
        {
            if (ModelState.IsValid)
            {
                var book = _AdminDb.Book.Find(model.ID);
                if (book != null)
                {
                    book.Title = model.Title;
                    book.Author = model.Author;
                    book.Publisher = model.Publisher;
                    book.PublicationYear = model.PublicationYear;
                    book.Pages = model.Pages;
                    book.Edition = model.Edition;
                    book.Price = model.Price;
                    book.Description = model.Description;
                    book.BookType = model.BookType;


                    _AdminDb.SaveChanges();
                    return RedirectToAction("BookIndex");
                }
            }

            return View(model);
        }

        public ActionResult DeleteBook(int id)
        {
            Book book = _AdminDb.Book.Find(id);
            if (book != null)
            {
                _AdminDb.Book.Remove(book);
                _AdminDb.SaveChanges();
            }
            return RedirectToAction("BookIndex");
        }

        //=======================
        //Report                |
        //=======================
        //public ActionResult Report()
        //{
        //    if (Session["AdminID"] == null)
        //    {
        //        return RedirectToAction("Login", "Account");
        //    }

        //    var books = _AdminDb.Book.ToList();
        //    var users = _AdminDb.User.ToList();

        //    var mostActiveUsers = users
        //        .OrderByDescending(u => u.Books != null ? u.Books.Count : 0)
        //        .Take(5)
        //        .ToList();

        //    var newUser = users.OrderByDescending(u => u.ID).FirstOrDefault();

        //    var reportViewModel = new ReportViewModel
        //    {
        //        Books = books,
        //        BookCount = books.Sum(b => b.StockQuantity),
        //        SalesByCategory = "Category data here",
        //        TopSellingBooks = "Top selling books data here",
        //        TotalSales = "Total sales data here",

        //        Users = users,
        //        MostActiveUsers = mostActiveUsers,
        //        NewUsersThisMonth = newUser != null ? 1 : 0,

        //        LowStockItems = books.Where(b => b.StockQuantity > 0 && b.StockQuantity <= 15).ToList(),
        //        OutOfStockItems = books.Where(b => b.StockQuantity == 0).ToList(),
        //        RecentlyRestockedItems = books
        //            .Where(b => b.RestockDate.HasValue && b.RestockDate.Value >= DateTime.Now.AddDays(-30)).ToList(),
        //        UniqueTitlesCount = books.Select(b => b.Title).Distinct().Count(),

        //        RecentLogins = new List<User>()
        //    };

        //    return View(reportViewModel);
        //}
        public ActionResult Report()
        {
            if (Session["AdminID"] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var books = _AdminDb.Book.ToList();
            var users = _AdminDb.User.ToList();

            var groupedBooks = books
                .GroupBy(b => b.Title)
                .Select(g => new
                {
                    Title = g.Key,
                    Count = g.Count(),
                    SampleBook = g.FirstOrDefault()
                }).ToList();

        
            var lowStockItems = groupedBooks
                .Where(g => g.Count <= 2 && g.Count > 0)
                .Select(g => g.SampleBook)
                .ToList();

            var outOfStockItems = new List<Book>(); 

            var mostActiveUsers = users
                .OrderByDescending(u => u.Books != null ? u.Books.Count() : 0)
                .Take(5)
                .ToList();

            var newUser = users.OrderByDescending(u => u.ID).FirstOrDefault();

            var reportViewModel = new ReportViewModel
            {
                Books = books,
                BookCount = books.Count(), // total number of book records
                SalesByCategory = "Category data here",
                TopSellingBooks = "Top selling books data here",
                TotalSales = "Total sales data here",

                Users = users,
                MostActiveUsers = mostActiveUsers,
                NewUsersThisMonth = newUser != null ? 1 : 0,

                LowStockItems = lowStockItems,
                OutOfStockItems = outOfStockItems,
                RecentlyRestockedItems = new List<Book>(), 
                UniqueTitlesCount = groupedBooks.Count(),

                RecentLogins = new List<User>()
            };

            return View(reportViewModel);
        }



        //=======================
        //Dashboard             |
        //=======================
        public ActionResult DashBoard()
        {
            if (Session["AdminID"] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }



    }
}
