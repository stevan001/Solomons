namespace ProdigyProducts.BLL.Domain
{
    public class OrderDetail
    {
        public int DetailID { get; set; }
        public int? OrderID { get; set; }
        public int? ProductID { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public decimal? TotalItemPrice { get; set; }
    }
}
