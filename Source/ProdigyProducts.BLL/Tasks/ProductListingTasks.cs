using System.Collections.Generic;
using System.Web;
using ProdigyProducts.BLL.Domain;
using ProdigyProducts.BLL.Services;

namespace ProdigyProducts.BLL.Tasks
{
    public interface IProductListingTasks
    {
        IList<Domain.ProductCategory> GetCategories();
        IList<Domain.Product> GetCategoryProducts(int category);
        void RemoveProduct(int productId); 


    }

    public class ProductListingTasks : IProductListingTasks
    {
        Services.ProductCategoryService _categoryService = new ProductCategoryService();
        Services.ProductService _productService = new ProductService();
        public IList<ProductCategory> GetCategories()
        {
            return _categoryService.GetAllProductCategory(); 
        }

        public IList<Product> GetCategoryProducts(int category)
        {
            return _productService.GetProductsById(category); 
        }

        public void RemoveProduct(int productId)
        {
            _productService.Delete(_productService.GetProductById(productId));
        }
    }
}