using System;

namespace ProdigyProducts.BLL.Views
{
    public interface IAdminLoginView
    {
        string Username { get; }
        string Password { get; }
        bool AuthenticationResult { get; set; }
        string ForgotPasswordResult { get; set; }
        event EventHandler LoginClick;
        event EventHandler ForgotPassword; 
    }
}