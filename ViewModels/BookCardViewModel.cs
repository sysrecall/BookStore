using BookStore.Models.Store;

namespace BookStore.ViewModels
{
    public class BookCardViewModel
    {
        public Book Book { get; set; }
        public bool IsInCart { get; set; }
    }
}