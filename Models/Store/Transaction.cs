using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models.Store
{
    public class Transaction
    {
        public int ID { get; set; }
        [ForeignKey("Book")]
        public int BookID { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double TotalAmount { get; set; }
        
        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}