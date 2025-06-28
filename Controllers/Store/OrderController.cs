using System.IO;
using System.Linq;
using System.Web.Mvc;
using BookStore.Models.Store;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Drawing;
using QuestPDF.Infrastructure;
using BookStore.DAL;
using System.Web.Services.Description;

namespace BookStore.Controllers.Store
{
    public class OrderController : Controller
    {
        private BookStoreContext db;
        public OrderController()
        {
            db = new BookStoreContext();
        }   

        public FileStreamResult GetInvoice(int? orderID)
        {
            var order = db.Order.Include("OrderItems").Include("User").FirstOrDefault(_o => _o.ID == orderID);
            if (order != null)
            {
                var document = new InvoiceDocument(order);
                var pdfBytes = document.GeneratePdf(); // GeneratePdf returns a byte array
                var pdfStream = new MemoryStream(pdfBytes); // Wrap the byte array in a MemoryStream
                pdfStream.Seek(0, SeekOrigin.Begin); // Seek to the beginning of the stream
                return new FileStreamResult(pdfStream, "application/pdf") // Explicitly create a FileStreamResult
                {
                    FileDownloadName = $"Invoice_Order_{order.ID}.pdf"
                };
            }
            return new FileStreamResult(new MemoryStream(new byte[] { }), "application/pdf") // Explicitly create a FileStreamResult
            {
                FileDownloadName = "empty.pdf"
            };
        }
    }

    // 3. QuestPDF Document for Invoice
    public class InvoiceDocument : IDocument
    {
        private Order _order;

        public InvoiceDocument(Order order)
        {
            _order = order;
        }
        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
        public DocumentSettings GetSettings() => DocumentSettings.Default;

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(30);
                page.PageColor(Colors.White);
                page.DefaultTextStyle(x => x.FontSize(12));

                page.Header().Element(ComposeHeader);

                page.Content().Element(ComposeContent);

                page.Footer().Element(ComposeComments);
            });
        }


        void ComposeHeader(IContainer container)
        {
            container.Row(row =>
            {
                row.RelativeItem().Column(column =>
                {
                    column.Item()
                        .Text($"Order #{_order.ID}")
                        .FontSize(20).SemiBold().FontColor(Colors.Blue.Medium);

                    column.Item().Text(text =>
                    {
                        text.Span("Issue Date: ").SemiBold();
                        text.Span($"{_order.DatePlaced.ToShortDateString()}");
                    });
                });

                // row.ConstantItem(100).Height(50).Placeholder();
            });
        }

        void ComposeContent(IContainer container)
        {
            container.PaddingVertical(40).Column(column => 
            {
                column.Spacing(5);

                column.Item().Text($"Name: {_order.BillingName}");
                column.Item().Row(row =>
                {
                    row.RelativeItem().Component(new AddressComponent("Billing Address", _order.BillingAddress));
                    row.RelativeItem().Component(new AddressComponent("Shipping Address", _order.ShippingAddress));
                });

                column.Item().Element(ComposeTable);

                var totalPrice = _order.TotalAmount;
                column.Item().AlignRight().Text($"Grand total: {totalPrice}$").FontSize(14);

            });
        }

        void ComposeTable(IContainer container)
        {
            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.ConstantColumn(25);
                    columns.RelativeColumn(3);
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                });
            
                table.Header(header =>
                {
                    header.Cell().Element(CellStyle).Text("#");
                    header.Cell().Element(CellStyle).Text("Book");
                    header.Cell().Element(CellStyle).Text("Type");
                    header.Cell().Element(CellStyle).AlignRight().Text("Unit price");
                    header.Cell().Element(CellStyle).AlignRight().Text("Quantity");
                    header.Cell().Element(CellStyle).AlignRight().Text("Total");
                
                });

                int i = 0;
                foreach (var item in _order.OrderItems)
                {
                    table.Cell().Element(CellStyle).Text(i.ToString());
                    table.Cell().Element(CellStyle).Text(item.Book.Title);
                    table.Cell().Element(CellStyle).Text(item.BookType.ToString());
                    table.Cell().Element(CellStyle).AlignRight().Text($"{item.Price}$");
                    table.Cell().Element(CellStyle).AlignRight().Text(item.Quantity.ToString());
                    table.Cell().Element(CellStyle).AlignRight().Text($"{item.Price * item.Quantity}$");
                
                }
            });
        }
        static IContainer CellStyle(IContainer container)
        {
            return container.BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(5);
        }
        
        void ComposeComments(IContainer container)
        {
            container.Background(Colors.Grey.Lighten3).Padding(10).Column(column =>
            {
                column.Spacing(5);
                column.Item().Text("Comments").FontSize(14);
                column.Item().Text("No Refund!");
            });
        } 
    }
    public class AddressComponent : IComponent
    {
        private string Title { get; }
        private string Address { get; }

        public AddressComponent(string title, string address)
        {
            Title = title;
            Address = address;
        }

        public void Compose(IContainer container)
        {
            container.Column(column =>
            {
                column.Spacing(2);

                column.Item().BorderBottom(1).PaddingBottom(5).Text(Title).SemiBold();

                column.Item().Text(Address);
            });
        }
    }
}
