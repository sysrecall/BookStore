using BookStore.Models.Store;

namespace BookStore.ViewModels
{
    public class BookCardViewModel
    {
        public Book Book { get; set; }
        public bool IsInCart { get; set; }
        public bool IsOwned { get; set; }
        public int QuantityInCart { get; set; } = 0;
    }
}