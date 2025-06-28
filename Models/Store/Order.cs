using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models.Store
{
    public class Order
    {
        public int ID { get; set; }

        [ForeignKey("User")]
        public int? UserID { get; set; }
        public DateTime DatePlaced { get; set; } = DateTime.Now;
        public double TotalAmount { get; set; }

        public string ShippingName { get; set; }
        public string ShippingAddress { get; set; }

        public string BillingName { get; set; }
        public string BillingAddress { get; set; }

        public string PaymentMethod { get; set; }
        public int PaymentID { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}