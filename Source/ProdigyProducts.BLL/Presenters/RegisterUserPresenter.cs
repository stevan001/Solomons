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
        private AccountDetailService _accountDetailServ = new AccountDetailService();
        private LoginService _loginService = new LoginService();
        private IRegistrationTask _tasks; 
        public RegisterUserPresenter(IRegisterUserView view) : this(view, new RegistrationTask())
        {
            
        }
        
        public RegisterUserPresenter( IRegisterUserView view, IRegistrationTask task )
        {
            _view = view;
            _view.RegisterEvent += RegisterClickEvent;

            _tasks = task;

        }

        public void Initailize()
        {
            
        }

        public void Register()
        {  
            AccountDetail details = new AccountDetail();
            Login newLogin = new Login();
            try
            {
              
                details.FirstName = "Stevan";
                details.LastName = _view.LastName;
                details.Email = _view.Email;
                details.Address = _view.Address;
                details.BillingAddress = _view.BillingAddress;
                details.PhoneNumber = _view.Phone; 
                
                newLogin.Email = details.Email;
                newLogin.Password = ""; 
                
                _tasks.RegisterAccount(newLogin,details);
            }
            catch (Exception e)
            {
                //push a message back to the page 
                _tasks.RemoveAccount(newLogin);
               
                _view.RegisterResult = "Sorry your account could not be registered. "; 
            }
        }

        public void RegisterClickEvent(object sender, EventArgs e)
        {
            this.Register();
        }


       

    }
}