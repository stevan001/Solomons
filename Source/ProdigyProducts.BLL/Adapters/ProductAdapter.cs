using ProdigyProducts.BLL.Domain;

namespace ProdigyProducts.BLL.Adapters
{
    public class ProductAdapter : IAdapter<Data.Product, Domain.Product>
    {
        public Product ConvertToDomainObject(Data.Product dataObject)
        {
            Domain.Product product = new Product();
            product.ProductId = dataObject.product_id;
            product.Title = dataObject.title;
            product.Feature = dataObject.feature;
            product.Price = dataObject.price;
            product.Description = dataObject.description;
            product.Quantity = dataObject.quantity;
            return product; 
        }

        public Data.Product ConvertToDataObject(Product domainObject)
        {
            Data.Product product = new Data.Product();
            product.product_id = domainObject.ProductId;
            product.title = domainObject.Title;
            product.feature = domainObject.Feature;
            product.price = domainObject.Price;
            product.description = domainObject.Description;
            product.quantity = domainObject.Quantity;
            return product; 
        }

        public void UpdateDataObject(Product domainObject, ref Data.Product dataObject)
        {

            dataObject.title = domainObject.Title;
            dataObject.feature = domainObject.Feature;
            dataObject.price = domainObject.Price;
            dataObject.description = domainObject.Description;
            dataObject.quantity = domainObject.Quantity;
        }
    }

}
    
    
