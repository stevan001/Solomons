using System;

namespace ProdigyProducts.BLL.Views
{
    public interface ICompleteRegView
    {
        string RegistrationCode { get; }
        string RegistationResult { set; }
        bool ProcedeToLogin {  set; }
        event EventHandler CompleteRegistrationClick; 
    }
}