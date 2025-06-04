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
            var accounts = new List<Account>
            {
                new Account{Username="admin", PasswordHash="admin", Role = "Admin"},
                new Account{Username="user", PasswordHash="user", Role = "User"}
            };

            var books = new List<Book>
            {
                new Book
                {
                    Title = "To Kill a Mockingbird", Author = "Harper Lee", Publisher = "Grand Central Publishing",
                    PublicationYear = new DateTime(1988, 10, 11), Pages = 384, Edition = "1st Edition",
                    Price = 21.25, BookType = BookType.eBook,
                    BookCoverImages = new List<BookCoverImage>
                    {
                        new BookCoverImage
                        {
                            ImageURL = "https://m.media-amazon.com/images/I/71FxgtFKcQL._SL1500_.jpg"
                        }
                    }
                }
            };

            accounts.ForEach(a => context.Account.Add(a));
            books.ForEach(b => context.Books.Add(b));
            
            context.SaveChanges();
        } 
    }
}