using ProdigyProducts.BLL.Domain;

namespace ProdigyProducts.BLL.Tasks
{
    public interface IRegistrationTask
    {
         void RegisterAccount(Login login, AccountDetail detail);
         void RemoveAccount (Login login);
    }
}