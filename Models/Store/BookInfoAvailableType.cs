namespace BookStore.Models.Store
{
    public class BookInfoAvailableType
    {
        public int ID { get; set; }
        public BookType BookType { get; set; }
        public int BookInfoID { get; set; }
        public virtual BookInfo BookInfo { get; set; }
    }
}