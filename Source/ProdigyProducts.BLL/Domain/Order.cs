using System;

namespace ProdigyProducts.BLL.Domain
{
    public class Order
    {
        public int OrderID { get; set; }
        public string ShipppingAddress { get; set; }
        public decimal? Total { get; set; }
        public decimal? Tax { get; set; }
        public string BillingAddress { get; set; }
        public int? AccountID { get; set; }
        public DateTime? OrderDate { get; set; }
        public string OrderStatus { get; set; }
    }
}
