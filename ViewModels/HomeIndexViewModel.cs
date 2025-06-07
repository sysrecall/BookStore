using BookStore.Models.Store;
using System.Collections.Generic;

namespace BookStore.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<Book> Books { get; set; }
        public List<Category> Categories { get; set; }
        public string SearchQuery { get; set; }
        public Category? SelectedCategory { get; set; }

        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
