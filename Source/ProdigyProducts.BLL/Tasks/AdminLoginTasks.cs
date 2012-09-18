using System;
using System.Text;
using ProdigyProducts.BLL.Domain;
using ProdigyProducts.BLL.Services;

namespace ProdigyProducts.BLL.Tasks
{
    public class AdminLoginTasks : IAdminLoginTasks
    {
        private LoginService _loginService =new LoginService();
        private AccountDetailService _detailService = new AccountDetailService(); 

        public bool Authenticate(string username, string password)
        {
            return _loginService.AuthenticateAdmin(username, password); 
        }

        public string InitiatePasswordReset(string username)
        {
           return SendPasswordResetEmail(username); 
        }

       

        public string SendPasswordResetEmail(string username)
        {
            //1. we need to generate a temporary password and email it to the user. 
            string message;
            var userDetails = GenerateUserResetMessage(username, out message);
            EmailService.SendMail(userDetails.Email,string.Format("{0} {1}",userDetails.FirstName,userDetails.LastName),"Account Reset", message);
            return "An Email has been sent with you reset information.";
        }

        private IAccountDetail GenerateUserResetMessage(string username, out string message)
        {
            StringBuilder sb = new StringBuilder();
            var login = _loginService.GetLoginByUsername(username); 

            var generatedPassword = ResetPassword(login);
            var userDetails = _detailService.GetAccountDetailByEmail(username);
            sb.AppendFormat("Hello {0}, <br />", userDetails.FirstName);
            sb.AppendFormat("You can now login with the following password <strong>{0}</strong>", generatedPassword);
            sb.AppendFormat("Please remember to change your password when you login.");
            message = sb.ToString();
            return userDetails;
        }

        private string ResetPassword(ILogin login)
        {
            string generatedPassword = System.IO.Path.GetRandomFileName().Replace(".", "");
            if (login != null)
            {
                login.Password = generatedPassword;
                _loginService.Update(login);
            }
            return generatedPassword;
        }
    }
}