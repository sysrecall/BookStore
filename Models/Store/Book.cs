using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models.Store
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime PublicationYear { get; set; }
        public int Pages { get; set; }
        public string Edition { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public BookType BookType { get; set; }

        public virtual ICollection<BookCoverImage> BookCoverImages { get; set; }
    }

    public enum BookType
    {
        Hardcover,
        Paperback,
        eBook,
        Audiobook
    }
}