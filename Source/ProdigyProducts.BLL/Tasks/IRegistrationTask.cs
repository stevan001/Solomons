using ProdigyProducts.BLL.Domain;

namespace ProdigyProducts.BLL.Tasks
{
    public interface IRegistrationTask
    {
        ILogin LoginAccount { get; set; }
        IAccountDetail AccountDetails { get; set; }
        void RegisterAccount(Login login, AccountDetail detail);
        void RegisterAccount();
        void RemoveAccount(Login login);
        string GenerateEmail();
        bool CompleteRegistration(string code); 
    }
}