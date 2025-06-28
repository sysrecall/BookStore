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


                existingAdmin.FirstName = admin.FirstName;
                existingAdmin.LastName = admin.LastName;
                existingAdmin.Email = admin.Email;
                existingAdmin.Department = admin.Department;
                existingAdmin.Position = admin.Position;
                existingAdmin.JoinDate = admin.JoinDate;

                if (existingAdmin.Account != null && admin.Account != null)
                {
                    existingAdmin.Account.Username = admin.Account.Username;
                    existingAdmin.Account.PasswordHash = admin.Account.PasswordHash;
                    existingAdmin.Account.Role = "Admin";
                }

                _AdminDb.SaveChanges();

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


        public ActionResult AddUser()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddUser(AddUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var account = new Account
                {
                    Username = model.Username,
                    PasswordHash = model.Password, 
                    Role = "User"
                };

                _AdminDb.Account.Add(account);
                _AdminDb.SaveChanges(); 

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

             var books = _AdminDb.Book.Include(b => b.BookInfo).Include(b=>b.Inventory).ToList();
             return View(books);
        }

        [HttpPost]
        public ActionResult AddBooks(Book book, string[] SelectedBookTypes, HttpPostedFileBase Image)
        {
            if (ModelState.IsValid)
            {
                if (book.BookInfo != null)
                {
                    _AdminDb.BookInfo.Add(book.BookInfo);
                    _AdminDb.SaveChanges();
                    book.BookInfoID = book.BookInfo.ID;
                }

                if (Image != null && Image.ContentLength > 0)
                {
                    string folderPath = Server.MapPath("~/Books/cover/");
                    if (!Directory.Exists(folderPath))
                        Directory.CreateDirectory(folderPath);

                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(Image.FileName);
                    string filePath = Path.Combine(folderPath, uniqueFileName);
                    Image.SaveAs(filePath);

                    string imageUrl = Url.Content("~/Books/cover/" + uniqueFileName);
                    book.BookImages = new List<BookImage> { new BookImage { Url = imageUrl } };
                }

                _AdminDb.Book.Add(book);
                _AdminDb.SaveChanges();

                var inventory = new Inventory
                {
                    BookID = book.ID,
                    AmountInStock = book.TempAmountInStock
                };
                _AdminDb.Inventory.Add(inventory);

                if (SelectedBookTypes != null && SelectedBookTypes.Length > 0)
                {
                    foreach (var type in SelectedBookTypes)
                    {
                        if (Enum.TryParse(type, out BookType parsedType))
                        {
                            var bookTypeEntry = new BookInfoAvailableType
                            {
                                BookType = parsedType,
                                BookInfoID = book.BookInfoID
                            };
                            _AdminDb.BookInfoAvailableTypes.Add(bookTypeEntry);
                        }
                    }
                }

                _AdminDb.SaveChanges();
                return RedirectToAction("BookIndex");
            }

            return View("BookIndex");
        }



        public ActionResult EditBook(int id)
        {
            var book = _AdminDb.Book.Include("BookInfo.AvailableTypes").FirstOrDefault(b => b.ID == id);
            if (book == null) return HttpNotFound();

            var viewModel = new EditBookViewModel
            {
                ID = book.ID,
                Title = book.Title,
                Author = book.Author,
                Price = book.Price,
                Publisher = book.BookInfo.Publisher,
                PublicationYear = book.BookInfo.PublicationYear,
                Pages = book.BookInfo.Pages,
                Edition = book.BookInfo.Edition,
                Description = book.BookInfo.Description,
                Category = book.Category,
                SelectedTypes = book.BookInfo.AvailableTypes.Select(at => at.BookType).ToList()
            };

            return View(viewModel);
        }

      
        [HttpPost]
        public ActionResult EditBook(EditBookViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var book = _AdminDb.Book
                .Include("BookInfo.AvailableTypes")
                .FirstOrDefault(b => b.ID == model.ID);

            if (book == null)
                return HttpNotFound();

            book.Title = model.Title;
            book.Author = model.Author;
            book.Price = model.Price;
            book.Category = model.Category;

            book.BookInfo.Publisher = model.Publisher;
            book.BookInfo.PublicationYear = model.PublicationYear;
            book.BookInfo.Pages = model.Pages;
            book.BookInfo.Edition = model.Edition;
            book.BookInfo.Description = model.Description;

            _AdminDb.BookInfoAvailableTypes.RemoveRange(book.BookInfo.AvailableTypes);

            book.BookInfo.AvailableTypes = model.SelectedTypes.Select(t => new BookInfoAvailableType
            {
                BookType = t,
                BookInfoID = book.BookInfo.ID
            }).ToList();

            _AdminDb.SaveChanges();

            return RedirectToAction("BookIndex");
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


            var topSellingBooks = users
                .SelectMany(u => u.Books)
                .GroupBy(b => b.Title)
                .OrderByDescending(g => g.Count())
                .Take(5)
                .Select(g => g.Key)
                .ToList();

            var salesByCategory = users
                  .SelectMany(u => u.Books)
                  .GroupBy(b => b.Category)
                  .ToDictionary(g => g.Key, g => (decimal)g.Sum(b => b.Price));


            var newUser = users.OrderByDescending(u => u.ID).FirstOrDefault();

            var reportViewModel = new ReportViewModel
            {
                Books = books,
                BookCount = books.Count(), 
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

            var totalSales = _AdminDb.User
            .SelectMany(u => u.Books)
            .Sum(b => (double?)b.Price) ?? 0.0;


            var totalOrders = _AdminDb.User
                .SelectMany(u => u.Books)
                .Count();

            var topSellingData = _AdminDb.User
                .SelectMany(u => u.Books)
                .GroupBy(b => b.Title)
                .Select(g => new
                {
                    Title = g.Key,
                    Count = g.Count(),
                    FirstBook = g.FirstOrDefault() 
                })
                .OrderByDescending(g => g.Count)
                .Take(5)
                .ToList();

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
