using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;
using BookStore.DAL;
using BookStore.Models.api;

namespace BookStore.Controllers.api
{
    public class PaymentController : ApiController
    {
        private PaymentContext db;

        public PaymentController()
        {
            db = new PaymentContext();
        }

        [HttpPost]
        public IHttpActionResult CreatePayment(Payment payment)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Payment Data");
            
            if (payment.CardExpiryDate < DateTime.Now)
                return BadRequest("Card Expired!");
            
            payment.Status = PaymentStatus.Approved;
            payment.PaymentDate = DateTime.Now;
            
            if (new Random().NextDouble() < 0.2)
                payment.Status = PaymentStatus.Rejected;
                
            db.Payment.Add(payment);
            
            db.SaveChanges();

            return Ok(payment);
        }

        [HttpGet]
        public IHttpActionResult GetPayments()
        {
            return Ok(db.Payment.ToList());
        }

        [HttpGet]
        public IHttpActionResult GetPayment(int id)
        {
            var payment = db.Payment.FirstOrDefault(p => p.ID == id);
            if (payment == null)
                return NotFound();

            return Ok(payment);
        }
    }
}