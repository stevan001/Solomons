using System;
using System.Collections.Generic;
using ProdigyProducts.BLL.Domain;
using ProdigyProducts.BLL.Tasks;
using ProdigyProducts.BLL.Views;

namespace ProdigyProducts.BLL.Presenters
{
    public class AdminCategoryPresenter : IAdminCategoryPresenter
    {
        private IAdminProductCategoryView _view;
        private IAdminProductCategoryTasks _tasks; 
        public AdminCategoryPresenter(IAdminProductCategoryView view, IAdminProductCategoryTasks tasks)
        {
            _view = view;
            _tasks = tasks; 

        }

        
        public void Initalize()
        {
            _view.Edit += new System.EventHandler(Commit);
            _view.Select += new GridViewCommand(_view_Select);
            LoadCategories();
        }

       public void _view_Select(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            _view.Category = _tasks.LoadCategory(Convert.ToInt32(e.CommandArgument));
           

        }

        public void Commit(object sender, System.EventArgs e)
        {
            try
            {
                _tasks.SaveCategory(_view.Category);
                _view.EditResult = "Saved Successfully";
            }
            catch (Exception exception)
            {
                _view.EditResult = exception.Message; 
            }
        }

        public void LoadCategories()
        {
            _view.Categories = _tasks.LoadCategories();
        }
    }
}