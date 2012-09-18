using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using ProdigyProducts.BLL.Domain;

namespace ProdigyProducts.BLL.Views
{
    public  delegate void GridViewCommand(object sender, GridViewCommandEventArgs e);
    public interface IAdminProductCategoryView
    {
        IList<ProductCategory> Categories { set; }
        ProductCategory Category { get; set; }
        string EditResult { set; }
        event GridViewCommand Select;
        event EventHandler Edit; 


    }
}