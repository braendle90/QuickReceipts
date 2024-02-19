using QuickReceipts.Models;

namespace QuickReceipts.ViewModel
{
    public class ProductViewModel
    {
        public Order Orders { get; set; }

        public IEnumerable<Product> Products { get; set; }
        public Currency CurrencySymbol { get; set; }
    }
}
