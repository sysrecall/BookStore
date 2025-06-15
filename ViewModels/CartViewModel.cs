using System.Collections.Generic;
using System.Linq;
using BookStore.Models.Store;

namespace BookStore.ViewModels
{
    public class CartViewModel
    {
        public Cart Cart { get; set; }
        public double TotalPrice => Cart.CartItems.Sum(ci => ci.Book.Price * ci.Quantity); 
    }
}