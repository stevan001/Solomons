namespace ProdigyProducts.BLL.Domain
{
    public class ProductDetail
    {
        public int ProductDetailID { get; set; }
        public int? ProductID { get; set; }
        public string ProductType { get; set; }
        public int? AttributeID { get; set; }
        public int? AttributeValue { get; set; }
    }
}
