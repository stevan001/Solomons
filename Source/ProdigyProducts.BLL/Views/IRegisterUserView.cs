using System;

namespace ProdigyProducts.BLL.Views
{
    public delegate void ButtonClickHandler(object sender, EventArgs e);
    public interface  IRegisterUserView 
    {
       string FirstName { get; }
       string LastName { get;  }
       string Email { get;  }
       string Phone { get;  }
       string Address { get;  }
       string BillingAddress { get;  }
       string RegisterResult {set; }

        event EventHandler RegisterEvent; 


    }
}