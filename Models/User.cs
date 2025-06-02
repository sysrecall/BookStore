using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStore.Models.Store;

namespace BookStore.Models
{
    public class User
    {
        public int ID { get; set; }
        public string AccountID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        // public string SecurityQuestion { get; set; }
        // public string SecurityAnswer { get; set }
        
        public virtual Account Account { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}