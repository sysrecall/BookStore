using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStore.Models.Store;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class User
    {
        public int ID { get; set; }
        
        [ForeignKey("Account")]
        public int AccountID { get; set; }
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        public string ShippingAddress { get; set; }
        public string BillingAddress { get; set; }
        
        public string CardNumber { get; set; }
        public string CardPin { get; set; }
        public DateTime? CardExpiryDate { get; set; }

        public virtual Account Account { get; set; }

        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}