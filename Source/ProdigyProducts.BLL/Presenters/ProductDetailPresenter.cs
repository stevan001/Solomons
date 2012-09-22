using ProdigyProducts.BLL.Tasks;
using ProdigyProducts.BLL.Views;

namespace ProdigyProducts.BLL.Presenters
{
    public class ProductDetailPresenter
    {
       

        private IProductDetailsTasks _tasks;
        private IProductDetailsView _view;

        public ProductDetailPresenter(IProductDetailsView view ) : this (view , new ProductDetailsTasks())
        {
            
        }

        public ProductDetailPresenter(IProductDetailsView productDetailsView, IProductDetailsTasks productDetailsTasks)
        {
            _view = productDetailsView; 
            _tasks = productDetailsTasks;
        }
    }
}