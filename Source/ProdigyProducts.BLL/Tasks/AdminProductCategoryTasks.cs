using System.Collections.Generic;
using ProdigyProducts.BLL.Domain;
using ProdigyProducts.BLL.Services;

namespace ProdigyProducts.BLL.Tasks
{
    public interface IAdminProductCategoryTasks
    {
       
        void SaveCategory(Domain.ProductCategory category);
        Domain.ProductCategory LoadCategory(int categoryId);


        IList<ProductCategory> LoadCategories();
    }


    public class AdminProductCategoryTasks : IAdminProductCategoryTasks
    {
        private BLL.Services.ProductCategoryService _service = new ProductCategoryService(); 

        public IList<ProductCategory> Cateogryies
        {
            get { return _service.GetAllProductCategory(); }
        }

       

        public void SaveCategory(ProductCategory category)
        {
            if (category.CategoryID ==0)
                _service.Insert(category);
            else
            {
                _service.Update(category);
            }
        }

        public ProductCategory LoadCategory(int categoryId)
        {
            return _service.GetProductCategoryById(categoryId);
        }

        public IList<ProductCategory> LoadCategories()
        {
            return _service.GetAllProductCategory();
        }
    }
}