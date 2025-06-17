using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models.Store
{
    public class BookInfo
    {
        public int ID { get; set; }
        public string Publisher { get; set; }
        public DateTime PublicationYear { get; set; }
        public int Pages { get; set; }
        public string Edition { get; set; }
        public string Description { get; set; }
        public BookType BookType { get; set; }
        
    }
    
    public enum BookType
    {
        Hardcover,
        Paperback,
        eBook,
        Audiobook
    }
}