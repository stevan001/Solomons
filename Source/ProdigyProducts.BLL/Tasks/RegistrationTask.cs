using ProdigyProducts.BLL.Domain;
using ProdigyProducts.BLL.Services;

namespace ProdigyProducts.BLL.Tasks
{
    
    public class RegistrationTask : IRegistrationTask
    {
        LoginService _loginService  = new LoginService();
        AccountDetailService _accountDetail = new AccountDetailService();
        public void RegisterAccount(Login login, AccountDetail detail)
        {
            _loginService.Insert(login);
            _accountDetail.Insert(detail);
        }

        public void RemoveAccount(Login login)
        {
            //this should also delete the Account Details Record through refrential Integrity. 
            _loginService.Delete(login);
        }
    }
}