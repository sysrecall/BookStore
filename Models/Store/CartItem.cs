using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models.Store
{
    public class CartItem
    {
        public int ID { get; set; }
        [ForeignKey("Book")]
        public int BookID { get; set; }
        public Book Book { get; set; }

        public int CartID { get; set; }
        public Cart Cart { get; set; }

        public int Quantity { get; set; }
    }
}

