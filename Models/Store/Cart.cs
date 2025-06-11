using System.Collections;
using System.Collections.Generic;

namespace BookStore.Models.Store
{
    public class Cart
    {
        public int ID { get; set; }
        public User User { get; set; }
        public ICollection<Book> Books { get; set; }
        
        public virtual int UserID { get; set; }
    }
}