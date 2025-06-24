using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStore.Models;
using BookStore.Models.Store;

namespace BookStore.ViewModels
{
    public class DashBoardViewModel
    {

        public decimal TotalSales { get; set; }
        public int TotalOrders { get; set; }
        public int BooksInStock { get; set; }
        public int ActiveUsers { get; set; }
        public List<Inventory> Inventories { get; set; }

        //public List<MonthlySalesData> MonthlySales { get; set; }
        //public List<RecentActivityItem> RecentActivities { get; set; }
        public List<Book> LowStockItems { get; set; }
        public List<(Book Book, int Count)> TopSellingBooks { get; set; }
    }
}