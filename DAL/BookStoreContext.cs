using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BookStore.Models;
using BookStore.Models.Store;

namespace BookStore.DAL
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext() : base("BookStoreContext")
        {

        }

        public DbSet<Account> Account { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Book> Book { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}