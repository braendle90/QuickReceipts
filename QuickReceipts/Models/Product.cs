using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickReceipts.Models
{
    public class Product
    {

        [Key]
        public int ProductId { get; set; } // Primary key
        public string Name { get; set; }

        public int Pieces { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; } // Assuming currency is not a concern, or you're using a single currency
        public int StockQuantity { get; set; } // Optional, if you want to track inventory
    }
}
