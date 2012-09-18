using System;

namespace ProdigyProducts.BLL.Tasks
{
    public interface IAdminLoginTasks
    {
        
        bool Authenticate(string username, string password);
        string InitiatePasswordReset(string username);
        string SendPasswordResetEmail(string username);
    }
}