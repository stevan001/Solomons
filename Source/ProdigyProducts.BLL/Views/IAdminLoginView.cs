using System;

namespace ProdigyProducts.BLL.Views
{
    public interface IAdminLoginView
    {
        string Username { get; }
        string Password { get; }

        event EventHandler LoginClick;
        event EventHandler ForgotPassword; 
    }
}