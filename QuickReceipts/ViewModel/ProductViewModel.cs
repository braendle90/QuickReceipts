using QuickReceipts.Models;

namespace QuickReceipts.ViewModel
{
    public class ProductViewModel
    {

        public IEnumerable<Product> Products { get; set; }
        public Currency CurrencySymbol { get; set; }
    }
}
