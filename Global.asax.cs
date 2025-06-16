using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using BookStore.DAL;

namespace BookStore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // delete when prod
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BookStoreContext>());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_BeginRequest()
        {
            var context = HttpContext.Current;
            var guestCookie = context.Request.Cookies["GuestID"];

            if (guestCookie == null || string.IsNullOrWhiteSpace(guestCookie.Value))
            {
                string newGuestId = Guid.NewGuid().ToString();

                var cookie = new HttpCookie("GuestID", newGuestId)
                {
                    HttpOnly = true,
                    Expires = DateTime.Now.AddDays(7) 
                };

                context.Response.Cookies.Add(cookie);
            }
        }
    }
}
