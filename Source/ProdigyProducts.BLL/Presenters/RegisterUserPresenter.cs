using System;
using ProdigyProducts.BLL.Domain;
using ProdigyProducts.BLL.Views;

namespace ProdigyProducts.BLL.Presenters
{
    public class RegisterUserPresenter
    {
        private IRegisterUserView _view; 


        public RegisterUserPresenter( IRegisterUserView view )
        {
            _view = view;
            _view.RegisterEvent += RegisterClickEvent;
            //_view.RegisterButton.Click += RegisterClickEvent;

        }


        public void Register()
        {
            AccountDetail details = new AccountDetail();
            details.FirstName = "Stevan";
            details.LastName = _view.LastName;
            details.Email = _view.Email;
            details.Address = _view.Address;
            details.BillingAddress = _view.BillingAddress; 
        }

        public void RegisterClickEvent(object sender, EventArgs e)
        {
            this.Register();
        }

    }
}