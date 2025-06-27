using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

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
        public virtual ICollection<BookInfoAvailableType> AvailableTypes { get; set; }
    }
    
    public enum BookType
    {
        Hardcover,
        Paperback,
        eBook,
    }
}