using System.Data;
using System.Data.Objects.DataClasses;

namespace ProdigyProducts.BLL.Domain
{
   public class AccountDetail
    {
       public int AccountID { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string Email { get; set; }
       public string PhoneNumber { get; set; }
       public string Address { get; set; }
       public string BillingAddress { get; set; }




    }
}
