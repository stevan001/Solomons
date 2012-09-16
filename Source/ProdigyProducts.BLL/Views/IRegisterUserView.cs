using System;
using System.Collections.Generic;

namespace ProdigyProducts.BLL.Views
{
    public delegate void ButtonClickHandler(object sender, EventArgs e);
    
    public interface  IRegisterUserView 
    {
        #region Properties

        string FirstName { get; }
        string LastName { get; }
        string Email { get; }
        string Phone { get; }
        string Address { get; }
        string BillingAddress { get; }
        string RegisterResult { set; }
        string Password { get; }

        #endregion
        
        #region Events

        event EventHandler RegisterEvent;

        #endregion
        
    }

   
}