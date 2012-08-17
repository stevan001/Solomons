using ProdigyProducts.BLL.Domain;

namespace ProdigyProducts.BLL.Adapters
{
   public class ProductImageAdapter: IAdapter<Data.ProductImage,Domain.ProductImage>
   {
       public ProductImage ConvertToDomainObject(Data.ProductImage dataObject)
       {
           Domain.ProductImage productImage=new ProductImage();
           productImage.ImageId = dataObject.image_id;
           productImage.ImageLocation = dataObject.image_location;
           productImage.ProductId = dataObject.product_id;
           return productImage; 
       }

       public Data.ProductImage ConvertToDataObject(ProductImage domainObject)
       {
          Data.ProductImage productImage=new Data.ProductImage();
           productImage.image_id = domainObject.ImageId;
           productImage.image_location = domainObject.ImageLocation;
           productImage.product_id = domainObject.ProductId;
           return productImage;
       }

       public void UpdateDataObject(ProductImage domainObject, ref Data.ProductImage dataObject)
       {
           dataObject.image_location = domainObject.ImageLocation;
       }
   }
}
