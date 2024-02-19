namespace QuickReceipts.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string OrderNumber { get; set; }

        public decimal PriceTotalNetto { get; set; }
        public decimal PriceTotalBrutto { get; set; }

        public Customer Customer { get; set; }

        public List<ProductOrder> ProductOrderList { get; set; }


    }
}
