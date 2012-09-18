using System.Collections.Generic;
using System.Web.UI.WebControls;
using ProdigyProducts.BLL.Domain;

namespace ProdigyProducts.BLL.Views
{
    public interface IAdminProductCategoryView
    {
        IList<ProductCategory> Categories { get; }
        ProductCategory Category { get; set; }

       
       

    }
}