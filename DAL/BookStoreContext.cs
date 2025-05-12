using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BookStore.Models;

namespace BookStore.DAL
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext() : base("BookStoreContext")
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Admin> Admin { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<BookStore.Models.Store.Book> Books { get; set; }
    }
}