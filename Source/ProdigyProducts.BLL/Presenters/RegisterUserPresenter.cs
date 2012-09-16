using System;
using System.Collections.Generic;
using ProdigyProducts.BLL.Domain;
using ProdigyProducts.BLL.Services;
using ProdigyProducts.BLL.Tasks;
using ProdigyProducts.BLL.Views;

namespace ProdigyProducts.BLL.Presenters
{
    public class RegisterUserPresenter
    {
        private IRegisterUserView _view; 
        private IRegistrationTask _tasks; 
        public RegisterUserPresenter(IRegisterUserView view) : this(view, new RegistrationTask())
        {
            
        }
        
        public RegisterUserPresenter( IRegisterUserView view, IRegistrationTask task )
        {
            _view = view;
           _tasks = task;

        }

        public void Initailize()
        {
            _view.RegisterEvent += RegisterClickEvent;
        }

        public void Register()
        {  
            AccountDetail details = new AccountDetail();
            Login newLogin = new Login();
            try
            {
              
                details.FirstName = _view.FirstName;
                details.LastName = _view.LastName;
                details.Email = _view.Email;
                details.Address = _view.Address;
                details.BillingAddress = _view.BillingAddress;
                details.PhoneNumber = _view.Phone;  
                newLogin.Email = details.Email;
                newLogin.Password = _view.Password;
                _tasks.LoginAccount = newLogin;
                _tasks.AccountDetails = details; 
                _tasks.RegisterAccount(newLogin,details);
                _view.RegisterResult = "Thank you for creating an account. Please check your email for account activation insturctions"; 
            }
            catch (Exception e)
            {
                //push a message back to the page 
                _tasks.RemoveAccount(newLogin);
                _view.RegisterResult = "Sorry your account could not be registered. Please contact us if the problem persists."; 
            }
        }

        public void RegisterClickEvent(object sender, EventArgs e)
        {
            this.Register();
        }


       

    }
}