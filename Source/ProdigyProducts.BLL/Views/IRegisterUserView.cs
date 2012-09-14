using System;
using System.Collections.Generic;

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
<<<<<<< HEAD
       string RegisterResult {set; }
      
=======
        string RegisterResult { get; set; }

>>>>>>> 4b1c8ad7ecabe3c7859a59f36b1834a31b16ca90
        event EventHandler RegisterEvent; 


    }

   
}