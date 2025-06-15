using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using BookStore.DAL;
using BookStore.Models.Store;
using BookStore.ViewModels;
using Microsoft.Ajax.Utilities;

namespace BookStore.Controllers.Store
{
    public class CartController : Controller
    {
        private BookStoreContext db;

        public CartController()
        {
            db = new BookStoreContext();
        }

        public ActionResult Index()
        {
            if (Session["UserID"] == null)
            {
                if (Request.UrlReferrer != null) 
                    return Redirect(Request.UrlReferrer.ToString());
                return RedirectToAction("Login", "Account");
            }

            var userId = Convert.ToInt32(Session["UserID"]);

            var cart = db.Cart
                         .Include(c => c.CartItems.Select(ci => ci.Book))
                         .FirstOrDefault(c => c.UserID == userId);

            var cartViewModel = new CartViewModel
            {
                Cart = cart
            };

            return View(cartViewModel);
        }

        [HttpPost]
        public ActionResult AddBook(int? bookId)
        {
            if (Session["UserID"] == null || bookId == null)
                return RedirectToAction("Login", "Account");

            int userId = Convert.ToInt32(Session["UserID"]);

            var cart = db.Cart
                         .Include(c => c.CartItems)
                         .FirstOrDefault(c => c.UserID == userId);

            if (cart == null)
            {
                var user = db.User.Find(userId);
                cart = new Cart { UserID = userId, User = user };
                db.Cart.Add(cart);
            }

            var existingItem = cart.CartItems.FirstOrDefault(ci => ci.BookID == bookId.Value);
            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                cart.CartItems.Add(new CartItem
                {
                    BookID = bookId.Value,
                    Quantity = 1
                });
            }

            db.SaveChanges();
            return Redirect(Request.UrlReferrer?.ToString() ?? Url.Action("Index", "Home"));
        }

        [HttpPost]
        public ActionResult DecrementBook(int? bookId)
        {
            if (Session["UserID"] == null || bookId == null)
                return RedirectToAction("Login", "Account");

            int userId = Convert.ToInt32(Session["UserID"]);

            var cart = db.Cart.Include(c => c.CartItems).FirstOrDefault(c => c.UserID == userId);
            var item = cart?.CartItems.FirstOrDefault(ci => ci.BookID == bookId.Value);

            if (item != null)
            {
                item.Quantity--;
                if (item.Quantity <= 0)
                    db.CartItem.Remove(item);

                db.SaveChanges();
            }

            return Redirect(Request.UrlReferrer?.ToString() ?? Url.Action("Index", "Home"));
        }

        [HttpPost]
        public ActionResult RemoveBook(int? bookId)
        {
            if (Session["UserID"] == null || bookId == null)
                return RedirectToAction("Login", "Account");

            int userId = Convert.ToInt32(Session["UserID"]);

            var cart = db.Cart.Include(c => c.CartItems).FirstOrDefault(c => c.UserID == userId);
            var item = cart?.CartItems.FirstOrDefault(ci => ci.BookID == bookId.Value);

            if (item != null)
            {
                db.CartItem.Remove(item);
                db.SaveChanges();
            }

            return Redirect(Request.UrlReferrer?.ToString() ?? Url.Action("Index", "Home"));
        }

        [HttpPost]
        public ActionResult DeleteCart()
        {
            if (Session["UserID"] == null)
                return RedirectToAction("Login", "Account");

            int userId = Convert.ToInt32(Session["UserID"]);

            var cart = db.Cart.Include(c => c.CartItems).FirstOrDefault(c => c.UserID == userId);
            if (cart != null)
            {
                db.CartItem.RemoveRange(cart.CartItems);
                db.Cart.Remove(cart);
                db.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult Checkout()
        {
            if (Session["UserID"] == null)
                return RedirectToAction("Login", "Account");

            var userId = Convert.ToInt32(Session["UserID"]);
            var user = db.User.Find(userId);
            if (user == null)
                return RedirectToAction("Login", "Account");

            var cart = db.Cart
                .Include(c => c.CartItems.Select(ci => ci.Book))
                .FirstOrDefault(c => c.UserID == userId);

            if (cart?.CartItems == null || !cart.CartItems.Any())
            {
                TempData["Error"] = "Your cart is empty.";
                return RedirectToAction("Index", "Cart");
            }

            var order = new Order
            {
                UserID = userId,
                DatePlaced = DateTime.Now,
                OrderItems = new List<OrderItem>()
            };

            double totalAmount = 0;
            
            foreach (var cartItem in cart.CartItems)
            {
                var orderItem = new OrderItem
                {
                    BookID = cartItem.BookID,
                    Quantity = cartItem.Quantity,
                    Price = cartItem.Book.Price
                };
                totalAmount += orderItem.Total;

                order.OrderItems.Add(orderItem);
            }

            order.TotalAmount = totalAmount;

            db.Order.Add(order);
            db.CartItem.RemoveRange(cart.CartItems);
            db.Cart.Remove(cart);
            
            order.OrderItems.ForEach(oi => user.Books.Add(oi.Book)); 

            db.SaveChanges();
            
            return RedirectToAction("Index", "Home");
            // return RedirectToAction("OrderConfirmation", new { orderId = order.ID });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                db.Dispose();

            base.Dispose(disposing);
        }
    }
}
