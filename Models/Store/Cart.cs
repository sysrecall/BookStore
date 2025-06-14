using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models.Store
{
    public class Cart
    {
        public int ID { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        
        public virtual User User { get; set; }
        public ICollection<Book> Books { get; set; }
        
    }
}