using System;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models.api
{
    public class Payment
    {
        public int ID { get; set; }
        [Required]
        public string CardHolderName { get; set; }
        [Required]
        [MinLength(15)]
        public string CardNumber { get; set; }
        [Required]
        public string CardPin { get; set; }
        [Required]
        public DateTime? CardExpiryDate { get; set; }
        [Required]
        public double? Amount { get; set; }
        public DateTime? PaymentDate { get; set; }
        public PaymentStatus? Status { get; set; }
    }

    public enum PaymentStatus
    {
        // Pending,
        Approved,
        Rejected,
    }
}