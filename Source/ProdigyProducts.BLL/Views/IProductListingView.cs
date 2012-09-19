using System;
using System.Collections.Generic;
using ProdigyProducts.BLL; 
namespace ProdigyProducts.BLL.Views
{
    public interface IProductListingView
    {
        IList<Domain.ProductCategory> ProductCategories { set; }
        IList<Domain.Product> Products { set; }
        int SelectedCategoryId { get;  }

        event EventHandler CategorySelectionChanged; 
        event GridViewCommand Select;
        event GridViewCommand Edit;
        event GridViewCommand Delete;
      
    }
}