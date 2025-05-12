using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models.Store
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}