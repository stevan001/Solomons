using ProdigyProducts.BLL.Tasks;
using ProdigyProducts.BLL.Views;

namespace ProdigyProducts.BLL.Presenters
{
    public class AdminLoginPresenter 
    {
        private IAdminLoginView _view;
        private IAdminLoginTasks _tasks; 
        public AdminLoginPresenter(IAdminLoginView view ) : this (view , new AdminLoginTasks())
        {
            
        } 
        public AdminLoginPresenter(IAdminLoginView view, IAdminLoginTasks tasks )
        {
            _view = view;
            _tasks = tasks; 
        }
    }

}