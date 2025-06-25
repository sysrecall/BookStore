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
using System.Data.Entity;




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
        //public ActionResult Login()
        //{
        //      return View();
        //}
        //[HttpPost]
        //public ActionResult Login(Admin admin)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        var existingAdmin = _AdminDb.Admin.FirstOrDefault(a => a.Email == admin.Email );
        //        if (existingAdmin != null)
        //        {
        //            Session["AdminID"] = existingAdmin.Id;
        //            Session["AdminEmail"] = existingAdmin.Email;
        //            return RedirectToAction("DashBoard");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Invalid username or password.");
        //        }
        //        ViewBag.admin = existingAdmin;

        //    }
        //    return View(admin);
        //}

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
                admin.Account.Role = "Admin";
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

        public ActionResult EditAdminProfile(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var admin = _AdminDb.Admin.Include("Account").FirstOrDefault(a => a.Id == id);

            if (admin == null)
            {
                return HttpNotFound();
            }

            return View(admin);
        }

        [HttpPost]
        public ActionResult EditAdminProfile(Admin admin)
        {
            if (ModelState.IsValid)
            {
                var existingAdmin = _AdminDb.Admin
                    .Include("Account")
                    .FirstOrDefault(a => a.Id == admin.Id);

                //if (existingAdmin == null)
                //{
                //    return HttpNotFound("Admin not found with ID: " + admin.Id);
                //}

                // Update Admin fields
                existingAdmin.FirstName = admin.FirstName;
                existingAdmin.LastName = admin.LastName;
                existingAdmin.Email = admin.Email;
                existingAdmin.Department = admin.Department;
                existingAdmin.Position = admin.Position;
                existingAdmin.JoinDate = admin.JoinDate;

                // Update Account fields only if not null
                if (existingAdmin.Account != null && admin.Account != null)
                {
                    existingAdmin.Account.Username = admin.Account.Username;
                    existingAdmin.Account.PasswordHash = admin.Account.PasswordHash;
                    // Keep role safe
                    existingAdmin.Account.Role = "Admin";
                }

                try
                {
                    _AdminDb.SaveChanges();
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateConcurrencyException ex)
                {
                    ModelState.AddModelError("", "Unable to save changes. The record was updated or deleted by another user.");
                    return View(admin);
                }

                return RedirectToAction("AdminProfile");
            }

            return View(admin);
        }



        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Login", "Account");
        }


        //========================================================================
        //User related works
        //========================================================================
        public ActionResult Index()
        {
            if (Session["AdminID"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            var users = _AdminDb.User.Include("Account").ToList();
            ViewBag.NewUser = new User { Account = new Account() };
            return View(users);
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

        public ActionResult AddUser()
        {
            return View();
        }


        //[HttpPost]
        //public ActionResult AddUser(User user, string PasswordHash, string Role = "User")
        //{
        //    if (Session["AdminID"] == null)
        //        return RedirectToAction("Login", "Account");

        //    // Ensure Account is not null
        //    if (user.Account == null)
        //        user.Account = new Account();

        //    // Assign values from form if needed
        //    user.Account.PasswordHash = PasswordHash;
        //    user.Account.Role = Role;

        //    if (ModelState.IsValid)
        //    {
        //        _AdminDb.Account.Add(user.Account);
        //        _AdminDb.SaveChanges();

        //        user.AccountID = user.Account.ID;
        //        _AdminDb.User.Add(user);
        //        _AdminDb.SaveChanges();

        //        TempData["MsgAddUser"] = "User added successfully";
        //        return RedirectToAction("Index");
        //    }

        //    // On validation failure
        //    var users = _AdminDb.User.Include("Account").ToList();
        //    ViewBag.NewUser = user;
        //    return View("Index", users);
        //}
        [HttpPost]
        public ActionResult AddUser(AddUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var account = new Account
                {
                    Username = model.Username,
                    PasswordHash = model.Password, // optionally hash this
                    Role = "User"
                };

                _AdminDb.Account.Add(account);
                _AdminDb.SaveChanges(); // Save first to get the Account ID

                var user = new User
                {
                    AccountID = account.ID,
                    FullName = model.FullName,
                    Email = model.Email,

                };

                _AdminDb.User.Add(user);
                _AdminDb.SaveChanges();

                TempData["MsgAddUser"] = "User added successfully!";
                return RedirectToAction("Index");
            }

            return View(model);
        }


        public ActionResult DeleteUser(int id)
        {
            var user = _AdminDb.User.Find(id);
            if (user != null)
            {
                _AdminDb.User.Remove(user);
                _AdminDb.SaveChanges();
                TempData["MsgRem"] = "User has been deleted ";
            }
            return RedirectToAction("Index");
        }


        public ActionResult EditUser(int id)
        {
            var user = _AdminDb.User.Include("Account").FirstOrDefault(u => u.ID == id);

            if (user == null)
            {
                return HttpNotFound();
            }

            var viewModel = new User
            {
                ID = user.ID,
                FullName = user.FullName,
                Email = user.Email,
                Account = new Account
                {
                    Username = user.Account?.Username,
                    PasswordHash = user.Account?.PasswordHash
                }
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
                        user.Account.Username = model.Account.Username;
                    }

                    user.FullName = model.FullName;
                    user.Email = model.Email;

                    _AdminDb.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return View(model);
        }



        //===================================================================
        //Book related works here
        //===================================================================

        public ActionResult BookIndex()
        {
            if (Session["AdminID"] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            //ViewBag.BookTypeList = new SelectList(Enum.GetValues(typeof(BookType)).Cast<BookType>().Select(e => new SelectListItem
            //{
            //    Value = e.ToString(),
            //    Text = e.ToString()
            //}));

            //ViewBag.CategoryList = new SelectList(Enum.GetValues(typeof(Category)).Cast<Category>().Select(e => new SelectListItem
            //{
            //    Value = e.ToString(),
            //    Text = e.ToString()
            //}));

            //var data = _AdminDb.Book.ToList();
            //return View(data);
             var books = _AdminDb.Book.Include(b => b.BookInfo).ToList();
             return View(books);
        }


        [HttpPost]
        public ActionResult AddBooks(Book book, HttpPostedFileBase Image)
        {
            if (ModelState.IsValid)
            {
                // Save BookInfo first (this logic is fine)
                if (book.BookInfo != null)
                {
                    _AdminDb.BookInfo.Add(book.BookInfo);
                    _AdminDb.SaveChanges();
                    book.BookInfoID = book.BookInfo.ID;
                }

                // Save Image if present
                if (Image != null && Image.ContentLength > 0)
                {
                    string folderPath = Server.MapPath("~/Books/cover/");
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(Image.FileName);
                    string filePath = Path.Combine(folderPath, uniqueFileName);

                    Image.SaveAs(filePath);

                    // CORRECT: Create the URL and add it to the BookImages collection
                    string imageUrl = Url.Content("~/Books/cover/" + uniqueFileName);

                    book.BookImages = new List<BookImage>
            {
                new BookImage { Url = imageUrl }
            };
                }

                // Finally save the Book (EF will automatically save the related BookImage)
                _AdminDb.Book.Add(book);
                _AdminDb.SaveChanges();

                return RedirectToAction("BookIndex");
            }

            ViewBag.BookTypeList = new SelectList(Enum.GetNames(typeof(BookType)), book.BookInfo?.BookType.ToString());
            return View("BookIndex"); // Consider returning to the Add form with errors
        }


        //[HttpPost]
        //public ActionResult AddBooks(Book book, HttpPostedFileBase file)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (file != null && file.ContentLength > 0)
        //        {
        //            // Save the file and get the URL/path
        //            var bookImage = new BookImage { Url = "/Uploads/Books/" + Guid.NewGuid().ToString() + ".pdf" }; // Generate unique file path logic
        //            book.BookImages = new List<BookImage> { bookImage };
        //            book.BookPath = bookImage.Url; // Set BookPath to the image URL
        //        }

        //        _AdminDb.Book.Add(book);
        //        _AdminDb.SaveChanges();

        //        return RedirectToAction("BookIndex");
        //    }

        //    ViewBag.BookTypeList = new SelectList(Enum.GetNames(typeof(BookType)), book.BookInfo?.BookType.ToString());
        //    return View("AddBooks", book);
        //}





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
                var book = _AdminDb.Book.Include("BookInfo").FirstOrDefault(b => b.ID == model.ID);
                if (book != null)
                {
                    book.Title = model.Title;
                    book.Author = model.Author;
                    book.BookInfo.Publisher = model.BookInfo.Publisher;
                    book.BookInfo.PublicationYear = model.BookInfo.PublicationYear;
                    book.BookInfo.Pages = model.BookInfo.Pages;
                    book.BookInfo.Edition = model.BookInfo.Edition;
                    book.Price = model.Price;
                    book.BookInfo.Description = model.BookInfo.Description;
                    book.BookInfo.BookType = model.BookInfo.BookType;


                    _AdminDb.SaveChanges();
                    return RedirectToAction("BookIndex");
                }
            }

            return View(model);
        }

        public ActionResult DeleteBook(int id)
        {
            var book = _AdminDb.Book
                .Include(b => b.BookImages)
                .FirstOrDefault(b => b.ID == id);

            if (book != null)
            {
                // Delete associated BookImage entities first
                foreach (var coverImage in book.BookImages.ToList())
                {
                    _AdminDb.BookImage.Remove(coverImage);
                }
                _AdminDb.SaveChanges();

                // Then delete the Book entity
                _AdminDb.Book.Remove(book);
                _AdminDb.SaveChanges();
            }

            return RedirectToAction("BookIndex");
        }






        //======================================================================
        //Report                
        //======================================================================
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
            var inventory = _AdminDb.Inventory.ToList();


            var groupedBooks = books
                .GroupBy(b => b.Title)
                .Select(g => new
                {
                    Title = g.Key,
                    Count = g.Count(),
                    AmountInStock = g.FirstOrDefault()
                }).ToList();


            var lowStockItems = inventory
              .Where(i => i.AmountInStock <= 2 && i.AmountInStock > 0)
              .Select(i => i.Book)
              .ToList();


            var outOfStockItems = inventory
                    .Where(i => i.AmountInStock == 0)
                    .Select(i => i.Book)
                    .ToList();
            var mostActiveUsers = users
                .Where(u => u.Books != null && u.Books.Count > 0)
                .OrderByDescending(u => u.Books.Count)
                .Take(5)
                .ToList();

            var totalSales = _AdminDb.User
              .SelectMany(u => u.Books)
              .Sum(b => b.Price);


            var topSellingBooks = mostActiveUsers
                .SelectMany(u => u.Books)
                .GroupBy(b => b.Title)
                .OrderByDescending(g => g.Count())
                .Take(5)
                .Select(g => g.Key)
                .ToList();

            var salesByCategory = _AdminDb.User
                  .SelectMany(u => u.Books)
                  .GroupBy(b => b.Category)
                  .ToDictionary(g => g.Key, g => (decimal)g.Sum(b => b.Price));


            var newUser = users.OrderByDescending(u => u.ID).FirstOrDefault();

            var reportViewModel = new ReportViewModel
            {
                Books = books,
                BookCount = books.Count(), // total number of book records
                SalesByCategory = salesByCategory,
                TopSellingBooks = topSellingBooks,
                TotalSales = (decimal)totalSales,

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



        //===================================================================
        //Dashboard             |
        //===================================================================
        public ActionResult DashBoard()
        {
            if (Session["AdminID"] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var books = _AdminDb.Book.ToList();
            var inventories = _AdminDb.Inventory.ToList();

            var groupedBooks = books
                .GroupBy(b => b.Title)
                .Select(g => new
                {
                    Title = g.Key,
                    Count = g.Count(),
                    AmountInStock = g.FirstOrDefault()
                })
                .ToList();

            var lowStockItems = _AdminDb.Inventory
                .Where(i => i.AmountInStock <= 2 && i.AmountInStock > 0)
                .Select(i => i.Book)
                .ToList();

            var booksInStock = _AdminDb.Book.Count();

            // ✅ TotalSales = Sum of (Price * number of users who bought the book)
            var totalSales = _AdminDb.User
                .SelectMany(u => u.Books)
                .Sum(b => b.Price);

            // ✅ TotalOrders = Total number of books bought by users
            var totalOrders = _AdminDb.User
                .SelectMany(u => u.Books)
                .Count();


            // First get the raw data from database
            var topSellingData = _AdminDb.User
                .SelectMany(u => u.Books)
                .GroupBy(b => b.Title)
                .Select(g => new
                {
                    Title = g.Key,
                    Count = g.Count(),
                    FirstBook = g.FirstOrDefault() // Get one book from the group
                })
                .OrderByDescending(g => g.Count)
                .Take(5)
                .ToList();

            // Then transform to the format we need
            var topSellingBooks = topSellingData.Select(g => (
                Book: new Book
                {
                    Title = g.Title,
                    Author = g.FirstBook?.Author ?? "Unknown",
                    Price = g.FirstBook?.Price ?? 0
                },
                Count: g.Count
            )).ToList();



            var viewModel = new DashBoardViewModel
            {
                TotalSales = (decimal)totalSales,
                TotalOrders = totalOrders,
                ActiveUsers = _AdminDb.User.Count(),
                LowStockItems = lowStockItems,
                Inventories = inventories,
                BooksInStock = booksInStock,
                TopSellingBooks = topSellingBooks 

            };

            return View(viewModel);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _AdminDb.Dispose();
            }
            base.Dispose(disposing);
        }


    }
}
