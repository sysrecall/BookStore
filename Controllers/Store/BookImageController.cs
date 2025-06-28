using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore.DAL;

namespace BookStore.Controllers.Store
{
    public class BookImageController : Controller
    {
        private BookStoreContext db;

        public BookImageController()
        {
            db = new BookStoreContext();
        }

        public ActionResult Index(int id)
        {
            var image = db.BookImage.Find(id);
            if (image == null || string.IsNullOrEmpty(image.Url))
                return HttpNotFound();

            if (!System.IO.File.Exists(image.Url))
                return HttpNotFound();

            string contentType = MimeMapping.GetMimeMapping(image.Url);
            return File(image.Url, contentType);
        }
    }
}