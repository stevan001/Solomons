namespace ProdigyProducts.BLL.Domain
{
   public class ProductTypeAttribute
    {
       public int AttributeId { get; set; }
       public string AttributeName { get; set; }
       public string AttributeDataType { get; set; }
       public int? CategoryId { get; set; }

    }
}
