using System.Collections.Generic;
using System.Linq;
using BookStore.Models.Store;

namespace BookStore.ViewModels
{
    public class CartViewModel
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public double TotalPrice => Books?.Sum(b => b.Price) ?? 0; 
    }
}