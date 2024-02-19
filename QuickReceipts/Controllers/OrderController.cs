using Microsoft.AspNetCore.Mvc;
using QuickReceipts.Models;
using QuickReceipts.ViewModel;

namespace QuickReceipts.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            var firstOrder = new Order();
            Customer firstCustomer = new Customer
            {
                CompanyName = "A&B Textildruck GmbH"
            };


            var firstProduct = new Product
            {
                Description = "testFirst",
                Name = "NameFirst",
                Pieces = 133,
                Price = 22
            };
            var secondProduct = new Product
            {
                Description = "secondDescription",
                Name = "SecondName",
                Pieces = 12,
                Price = 12,

            };

            var productList = new List<Product>();
            productList.Add(firstProduct);
            productList.Add(secondProduct);




            firstOrder.OrderNumber = 1.ToString();
            firstOrder.Customer = firstCustomer;

            var viewmodel = new ProductViewModel();

            viewmodel.Orders = firstOrder;
            viewmodel.Products = productList;

            return View(viewmodel);
        }
    }
}
