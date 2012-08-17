namespace ProdigyProducts.BLL.Domain
{
   public class ProductRating
    {
       public int RateID { get; set; }
       public string RateBy { get; set; }
       public int? ProductID { get; set; }
    }
}
