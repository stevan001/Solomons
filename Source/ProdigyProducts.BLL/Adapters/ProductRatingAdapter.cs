using ProdigyProducts.BLL.Domain;

namespace ProdigyProducts.BLL.Adapters
{
   public class ProductRatingAdapter:IAdapter<Data.ProductRating,Domain.ProductRating>
   {
       public ProductRating ConvertToDomainObject(Data.ProductRating dataObject)
       {
           Domain.ProductRating productRating=new ProductRating();
           productRating.RateID = dataObject.rate_id;
           productRating.RateBy = dataObject.rate_by;
           productRating.ProductID = dataObject.product_id;
           return productRating; 
          
       }

       public Data.ProductRating ConvertToDataObject(ProductRating domainObject)
       {
           Data.ProductRating productRating=new Data.ProductRating();
           productRating.rate_id = domainObject.RateID;
           productRating.rate_by = domainObject.RateBy;
           productRating.product_id = domainObject.ProductID;
           return productRating; 
       }

       public void UpdateDataObject(ProductRating domainObject, ref Data.ProductRating dataObject)
       {
           dataObject.rate_by = domainObject.RateBy;
       }
   }
}
