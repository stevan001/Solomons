using System;
using System.Text;
using ProdigyProducts.BLL.Domain;
using ProdigyProducts.BLL.Services;

namespace ProdigyProducts.BLL.Tasks
{
    
    public class RegistrationTask : IRegistrationTask
    {
        ILoginService _loginService  = new LoginService();
        IAccountDetailService _accountDetailService = new AccountDetailService();
        
        public RegistrationTask(): this(new LoginService(), new AccountDetailService())
        {
            
        }
        public RegistrationTask(ILoginService loginService, IAccountDetailService accountDetailServiceService)
        {
            _loginService = loginService;
            _accountDetailService = accountDetailServiceService; 
        }
        public ILogin LoginAccount { get; set; }
        public IAccountDetail AccountDetails { get; set; }

        public void RegisterAccount(Login login, AccountDetail detail)
        {
            LoginAccount = login;
            AccountDetails = detail; 
            RegisterAccount();
        }

       
       
        public void RegisterAccount()
        {
            
            _loginService.Insert(LoginAccount);
            _accountDetailService.Insert(AccountDetails);
            string emailBody = GenerateEmail(); 
            EmailService.SendMail(LoginAccount.Email,string.Format("{0} {1}",AccountDetails.FirstName,AccountDetails.LastName),"Solomons Registration",emailBody);
        }


        public void RemoveAccount(Login login)
        {
            //this should also delete the Account Details Record through refrential Integrity. 
            _loginService.Delete(login);
        }

      
        public string GenerateEmail()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<div>");
            sb.AppendFormat(" Dear {0}, ",AccountDetails.FirstName); 
            sb.AppendFormat("<br />Thank you for registering. Please click the link below to complete the registration process., ");
            sb.AppendFormat("<br />Please check your junk email if you don't get an email within the next few minutes. ");
            sb.AppendFormat("<br />{0}CompleteRistration.aspx?Code={1}","http://www.solomonstt.com", _loginService.GenerateRegistrationCode()); 
            
            sb.Append("</div>");




            return sb.ToString();
        }

        public bool CompleteRegistration(string code)
        {

            try
            {
                _loginService.Register(code);
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
    }
}