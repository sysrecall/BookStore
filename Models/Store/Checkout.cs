using BookStore.Models.api;

namespace BookStore.Models.Store
{
    public class Checkout
    {
        public Payment Payment { get; set; }
        public string ShippingName { get; set; }
        public string ShippingAddress { get; set; }
        public string BillingName { get; set; }
        public string BillingAddress { get; set; }
    }
}