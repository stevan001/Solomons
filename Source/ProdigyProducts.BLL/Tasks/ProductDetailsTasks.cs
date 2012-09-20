using System.Collections.Generic;
using ProdigyProducts.BLL.Domain;
using ProdigyProducts.BLL.Services;

namespace ProdigyProducts.BLL.Tasks
{
    public interface IProductDetailsTasks
    {
        Domain.Product LoadProduct(int productId);
        void Save(Domain.Product product);
        IList<ProductCategory> LoadCategories(); 
    }

    public class ProductDetailsTasks : IProductDetailsTasks
    {
        Services.ProductService _productService = new ProductService();
        Services.ProductCategoryService _categoryService = new ProductCategoryService();

        public Product LoadProduct(int productId)
        {
            return _productService.GetProductById(productId);
        }

        public void Save(Product product)
        {
            if (product.ProductId ==0 )
                _productService.Insert(product);
            else
            {
                _productService.Update(product);
            }
        }

        public IList<ProductCategory> LoadCategories()
        {
            return _categoryService.GetAllProductCategory(); 
        }
    }
}