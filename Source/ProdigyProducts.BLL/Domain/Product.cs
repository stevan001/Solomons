using System.Collections.Generic;

namespace ProdigyProducts.BLL.Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Feature { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public IList<ProductTypeAttribute> Details { get; set; }
        public IList<ProductImage> Images { get; set; } 

    }
}
