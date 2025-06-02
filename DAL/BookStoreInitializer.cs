using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStore.Models;
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

            accounts.ForEach(a => context.Account.Add(a));
            context.SaveChanges();
        } 
    }
}