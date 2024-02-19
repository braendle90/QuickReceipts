namespace QuickReceipts.Models
{
    public class ProductOrder
    {

        public int ProductOrderId { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        // Weitere Eigenschaften der Verknüpfungstabelle, z.B. Menge, Preis, etc.

        // Navigationseigenschaften
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
