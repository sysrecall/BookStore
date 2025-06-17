using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using System.Web;
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
        
        private string GetGuestId()
        {
            var cookie = Request.Cookies["GuestID"];
            return cookie?.Value;
        }

        public ActionResult Index(CartViewModel cartViewModel)
        {
            if (cartViewModel == null)
                cartViewModel = new CartViewModel();
            
            Cart cart;
            
            if (Session["UserID"] != null)
            {
                var userId = Convert.ToInt32(Session["UserID"]);
                cart = db.Cart.Include(c => c.CartItems.Select(ci => ci.Book))
                              .FirstOrDefault(c => c.UserID == userId);
            }
            else
            {
                string guestId = GetGuestId();
                cart = db.Cart.Include(c => c.CartItems.Select(ci => ci.Book))
                              .FirstOrDefault(c => c.GuestID == guestId);
            }
            
            cartViewModel.Cart = cart;

            return View(cartViewModel);
        }

        [HttpPost]
        public ActionResult AddBook(int? bookId)
        {
            if (bookId == null)
                return RedirectToAction("Index");

            Cart cart;

            if (Session["UserID"] != null)
            {
                int userId = Convert.ToInt32(Session["UserID"]);
                cart = db.Cart.Include(c => c.CartItems).FirstOrDefault(c => c.UserID == userId);
                if (cart == null)
                {
                    var user = db.User.Find(userId);
                    cart = new Cart { UserID = userId, User = user };
                    db.Cart.Add(cart);
                }
            }
            else
            {
                string guestId = GetGuestId();
                cart = db.Cart.Include(c => c.CartItems).FirstOrDefault(c => c.GuestID == guestId);
                if (cart == null)
                {
                    cart = new Cart { GuestID = guestId };
                    db.Cart.Add(cart);
                }
            }

            var existingItem = cart.CartItems.FirstOrDefault(ci => ci.BookID == bookId.Value);
            if (existingItem != null)
                existingItem.Quantity++;
            else
                cart.CartItems.Add(new CartItem { BookID = bookId.Value, Quantity = 1 });

            db.SaveChanges();

            return Redirect(Request.UrlReferrer?.ToString() ?? Url.Action("Index", "Home"));
        }
 

        [HttpPost]
        public ActionResult DecrementBook(int? bookId)
        {
            if (bookId == null)
                return RedirectToAction("Login", "Account");
            
            Cart cart;
            if (Session["UserID"] != null)
            {
                int userId = Convert.ToInt32(Session["UserID"]);
                cart = db.Cart.Include(c => c.CartItems).FirstOrDefault(c => c.UserID == userId);
            }
            else
            {
                string guestId = GetGuestId();
                cart = db.Cart.Include(c => c.CartItems).FirstOrDefault(c => c.GuestID == guestId);
            }
 
            var item = cart?.CartItems.FirstOrDefault(ci => bookId != null && ci.BookID == bookId.Value);

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
            if (bookId == null)
                return RedirectToAction("Login", "Account");

            Cart cart;
            if (Session["UserID"] != null)
            {
                int userId = Convert.ToInt32(Session["UserID"]);
                cart = db.Cart.Include(c => c.CartItems).FirstOrDefault(c => c.UserID == userId);
            }
            else
            {
                string guestId = GetGuestId();
                cart = db.Cart.Include(c => c.CartItems).FirstOrDefault(c => c.GuestID == guestId);
            }
            
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
            Cart cart;
            if (Session["UserID"] != null)
            {
                int userId = Convert.ToInt32(Session["UserID"]);
                cart = db.Cart.Include(c => c.CartItems).FirstOrDefault(c => c.UserID == userId);
            }
            else
            {
                string guestId = GetGuestId();
                cart = db.Cart.Include(c => c.CartItems).FirstOrDefault(c => c.GuestID == guestId);
            }

            if (cart != null)
            {
                db.CartItem.RemoveRange(cart.CartItems);
                db.Cart.Remove(cart);
                db.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public ActionResult Checkout(CartViewModel cartViewModel)
        {
            if (Session["UserID"] == null)
            {
                TempData["RedirectAfterLogin"] = "Cart/Checkout";
                Session["GuestID"] = GetGuestId();
                return RedirectToAction("Register", "User");
            }

            var userId = Convert.ToInt32(Session["UserID"]);
            var cart = db.Cart.Include(c => c.CartItems.Select(ci => ci.Book))
                .FirstOrDefault(c => c.UserID == userId);

            if (cartViewModel == null)
                cartViewModel = new CartViewModel();

            cartViewModel.Cart = cart;
            return View(cartViewModel);
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
            // db.Cart.Remove(cart);
            
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
