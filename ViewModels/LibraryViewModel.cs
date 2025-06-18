using System.Collections.Generic;
using BookStore.Models.Store;

namespace BookStore.ViewModels
{
    public class LibraryViewModel
    {
        public List<Book> Books { get; set; }
        public string SearchQuery { get; set; }
        public Category? SelectedCategory { get; set; }
        public List<Category> Categories { get; set; }

        public int CurrentPage { get; set; }
        public int TotalPages { get; set; } 
    }
}