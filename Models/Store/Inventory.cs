using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models.Store
{
    public class Inventory
    {
        public int ID { get; set; }
        
        [ForeignKey("Book")]
        public int BookID { get; set; }
        public int AmountInStock { get; set; }
        
        public virtual Book Book { get; set; }
    }
}