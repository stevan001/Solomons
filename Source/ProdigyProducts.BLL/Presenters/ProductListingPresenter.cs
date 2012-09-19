using System.Web;
using ProdigyProducts.BLL.Tasks;
using ProdigyProducts.BLL.Views;

namespace ProdigyProducts.BLL.Presenters
{
    public class ProductListingPresenter
    {
        private IProductListingTasks _task;
        private IProductListingView _view;
        private System.Web.HttpContext _context; 
        public ProductListingPresenter(IProductListingView productListingView, IProductListingTasks productListingTasks)
        {
            _view = productListingView;
            _task = productListingTasks;

        }
        public ProductListingPresenter(IProductListingView productListingView, IProductListingTasks productListingTasks,HttpContext context)
        {
            _view = productListingView;
            _task = productListingTasks; 
            _context = context; 
        }

        public void Initalize()
        {
            _view.Select += _view_Select;
            _view.Delete += _view_Delete;
            _view.Edit += _view_Edit;
            _view.CategorySelectionChanged += _view_CategorySelectionChanged;
        }

        void _view_CategorySelectionChanged(object sender, System.EventArgs e)
        {
            Load();
        }

        void _view_Edit(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        void _view_Delete(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        void _view_Select(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            _context.Response.Redirect(string.Format("~/Admin/ProductDetails.aspx?id={0}",e.CommandArgument));   
        }

        public void Load()
        {
            _view.ProductCategories = _task.GetCategories();
            _view.Products = _task.GetCategoryProducts(_view.SelectedCategoryId); 

        }
    }
}