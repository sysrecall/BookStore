using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BookStore.Models.Store;

namespace BookStore.ViewModels
{
    public class EditBookViewModel
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        public string Author { get; set; }

        public double Price { get; set; }

        public string Publisher { get; set; }

        public DateTime PublicationYear { get; set; }

        public int Pages { get; set; }

        public string Edition { get; set; }

        public string Description { get; set; }

        [Display(Name = "Available Types")]
        public List<BookType> SelectedTypes { get; set; } = new List<BookType>();

        public Category Category { get; set; }
    }
}

