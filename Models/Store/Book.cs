using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookStore.Models.Store
{
    public class Book
    {
        public int ID { get; set; }
        [ForeignKey("BookInfo")]
        public int BookInfoID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string BookPath { get; set; }
        public int SoldInLifetime { get; set; }
        [Range(0,5)]
        public float Rating { get; set; }
        public int RatingCount { get; set; }
        
        public Category Category { get; set; }

        public virtual BookInfo BookInfo { get; set; }
        public virtual ICollection<BookImage> BookImages { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<User> Users { get; set; } 
    }

    public enum Category
    {
        Classic,
        Fantasy,
        Fiction,
        SciFi,
        NonFiction,
        Adventure,
        Biography,
        History,
    }
}