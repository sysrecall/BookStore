using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models.Store
{
    public class OrderItem
    {
        public int ID { get; set; }

        [ForeignKey("Order")]
        public int OrderID { get; set; }
        [ForeignKey("Book")]
        public int BookID { get; set; }
        public BookType BookType { get; set; }

        public int Quantity { get; set; }
        public double Price { get; set; }
        
        public double Total => Price * Quantity;

        public virtual Book Book { get; set; }
        public virtual Order Order { get; set; } 
    }
}