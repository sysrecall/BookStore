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
    }
}