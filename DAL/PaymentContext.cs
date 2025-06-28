using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BookStore.Models;
using BookStore.Models.api;
using BookStore.Models.Store;

namespace BookStore.DAL
{
    public class PaymentContext : DbContext
    {
        public PaymentContext() : base("PaymentContext")
        {

        }

        public DbSet<Payment> Payment { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}