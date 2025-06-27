using System.Collections.Generic;
using System.Web.Mvc;
using BookStore.Models.Store;

namespace BookStore.ViewModels
{
    public class BookCardViewModel
    {
        public Book Book { get; set; }
        public bool IsInCart { get; set; }
        public bool IsOwned { get; set; }
        public bool IsInStock { get; set; } = false;
        public int QuantityInCart { get; set; } = 0;
        
        public BookType? SelectedBookType { get; set; }
        
        public List<Book> RecommendedBooks = new List<Book>();
    }
}