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
        public string SalesByCategory { get; set; }
        public string TopSellingBooks { get; set; }
        public string TotalSales { get; set; }

        //users
        public List<User> Users { get; set; }
        public int TotalUsers => Users?.Count ?? 0;
        public int ActiveUsers => Users?.Count(u => u.Books != null && u.Books.Any()) ?? 0;
        public int NewUsersThisMonth { get; set; }
        public List<User> MostActiveUsers { get; set; }
        public List<User> RecentLogins { get; set; }

    }
}