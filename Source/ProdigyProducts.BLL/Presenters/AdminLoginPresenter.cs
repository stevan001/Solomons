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

      public void Initialize()
      {
          _view.LoginClick += _view_LoginClick;
          _view.ForgotPassword += _view_ForgotPassword;
      }

      void _view_ForgotPassword(object sender, System.EventArgs e)
      {
          _view.ForgotPasswordResult = _tasks.SendPasswordResetEmail(_view.Username);

      }

      public void _view_LoginClick(object sender, System.EventArgs e)
      {

          _view.AuthenticationResult = _tasks.Authenticate(_view.Username, _view.Password); 
         

      }
        

    }

}