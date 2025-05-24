using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
	public class Report
	{
		public int Id { get; set; }
		public string BookCount { get; set; }
		public string SalesByCategory { get; set; }
        public string TopSellingBooks { get; set; }
        public string TotalSales { get; set; }
    }
}