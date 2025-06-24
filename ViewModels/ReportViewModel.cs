using BookStore.Models;
using BookStore.Models.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.ViewModels
{
	public class ReportViewModel
	{
        public List<Book> Books { get; set; }
        public int BookCount { get; set; }
        public Dictionary<Category, decimal> SalesByCategory { get; set; } // Category name and total sales
        public List<string> TopSellingBooks { get; set; }
        //public List<Book> TopSellingBooks { get; set; }
        //public List<int> TopSellingBooksCounts { get; set; }
        public decimal TotalSales { get; set; }

        //users
        public List<User> Users { get; set; }
        public int TotalUsers => Users?.Count ?? 0;
        public int ActiveUsers => Users?.Count(u => u.Books != null && u.Books.Any()) ?? 0;
        public int NewUsersThisMonth { get; set; }
        public List<User> MostActiveUsers { get; set; }
        public List<User> RecentLogins { get; set; }

        //Books
        public List<Book> LowStockItems { get; set; }
        public List<Book> OutOfStockItems { get; set; }
        public List<Book> RecentlyRestockedItems { get; set; }
        public int UniqueTitlesCount { get; set; }


        


    }
}