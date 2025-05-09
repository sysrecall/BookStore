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
            var users = new List<User>
            {
                new User{Username="johndoe", PasswordHash="123"}
            };

            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();
        }
    }
}