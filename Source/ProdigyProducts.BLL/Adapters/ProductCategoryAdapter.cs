using ProdigyProducts.BLL.Domain;

namespace ProdigyProducts.BLL.Adapters
{
    public class ProductCategoryAdapter : IAdapter<Data.ProductCategory, Domain.ProductCategory>
    {
        public ProductCategory ConvertToDomainObject(Data.ProductCategory dataObject)
        {
            Domain.ProductCategory productCategory = new ProductCategory();
            productCategory.CategoryID = dataObject.category_id;
            productCategory.CategoryName = dataObject.category_name;
            productCategory.CategoryImage = dataObject.category_image;
            return productCategory; 
        }

        public Data.ProductCategory ConvertToDataObject(ProductCategory domainObject)
        {
            Data.ProductCategory productCategory = new Data.ProductCategory();
            productCategory.category_id = domainObject.CategoryID;
            productCategory.category_name = domainObject.CategoryName;
            productCategory.category_image = domainObject.CategoryImage;
            return productCategory;
        }

        public void UpdateDataObject(ProductCategory domainObject, ref Data.ProductCategory dataObject)
        {
            dataObject.category_id = domainObject.CategoryID;
            dataObject.category_name = domainObject.CategoryName;
            dataObject.category_image = domainObject.CategoryImage;
        }
    }
}
    
   