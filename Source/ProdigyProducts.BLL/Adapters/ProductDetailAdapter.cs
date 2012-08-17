using ProdigyProducts.BLL.Domain;

namespace ProdigyProducts.BLL.Adapters
{
   public class ProductDetailAdapter: IAdapter<Data.ProductDetail,Domain.ProductDetail>
   {
       public ProductDetail ConvertToDomainObject(Data.ProductDetail dataObject)
       {
           Domain.ProductDetail productDetail=new ProductDetail();
           productDetail.ProductDetailID = dataObject.product_details_id;
           productDetail.ProductID = dataObject.product_id;
           productDetail.ProductType = dataObject.product_type;
           productDetail.AttributeID = dataObject.attribute_id;
           productDetail.AttributeValue = dataObject.attribute_value;
           return productDetail; 

       }

       public Data.ProductDetail ConvertToDataObject(ProductDetail domainObject)
       {
           Data.ProductDetail productDetail=new Data.ProductDetail();
           productDetail.product_details_id = domainObject.ProductDetailID;
           productDetail.product_id = domainObject.ProductID;
           productDetail.product_type = domainObject.ProductType;
           productDetail.attribute_id = domainObject.AttributeID;
           productDetail.attribute_value = domainObject.AttributeValue;
           return productDetail; 
       }

       public void UpdateDataObject(ProductDetail domainObject, ref Data.ProductDetail dataObject)
       {
           dataObject.product_details_id = domainObject.ProductDetailID;
           dataObject.product_id = domainObject.ProductID;
           dataObject.product_type = domainObject.ProductType;
           dataObject.attribute_id = domainObject.AttributeID;
           dataObject.attribute_value = domainObject.AttributeValue;
       }
   }
}
