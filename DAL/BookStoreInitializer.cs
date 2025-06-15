using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStore.Models;
using BookStore.Models.Store;
using System.Data.Entity;

namespace BookStore.DAL
{
    public class BookStoreInitializer : DropCreateDatabaseIfModelChanges<BookStoreContext>
    {
        protected override void Seed(BookStoreContext context)
        {
            // base.Seed(context);
            var admins = new List<Admin>
            {
                new Admin
                {
                    Department = "Admin",
                    Email = "admin@admin.com",
                    Account = new Account
                    {
                        Username="admin", PasswordHash="admin", Role = "Admin"
                    },
                    FirstName = "Admin",
                    LastName = "Admin",
                    Position = "Admin",
                    JoinDate = "2/2/2025"
                }
            };

            var users = new List<User>
            {
                new User
                {
                    Account = new Account { Username = "john", PasswordHash = "john", Role = "User" },
                    Books = null,
                    Email = "john@john.john",
                    FullName = "John",
                },
                new User
                {
                    Account = new Account { Username = "user", PasswordHash = "user", Role = "User" },
                    Books = null,
                    Email = "user@user.user",
                    FullName = "User",
                }
            };
            
            var books = new List<Book>
            {
                new Book
                {
                    Title = "To Kill a Mockingbird", Author = "Harper Lee", Publisher = "Grand Central Publishing",
                    PublicationYear = new DateTime(1988, 10, 11), Pages = 384, Edition = "1st Edition",
                    Price = 21.25, BookType = BookType.eBook, Category = Category.Classic, SoldInLifetime = 1234,
                    Rating = 4.0f, BookPath = "~/Content/Books/test.pdf",
                    BookImages = new List<BookImage>
                    {
                        new BookImage {
                            Url =  "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
                        }
                    }
                }
            };

            admins.ForEach(a => context.Admin.Add(a));
            users.ForEach(u => context.User.Add(u));
            books.ForEach(b => context.Book.Add(b));
            
            context.SaveChanges();
        } 
    }
}