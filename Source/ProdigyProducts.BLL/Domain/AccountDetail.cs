using System.Data;
using System.Data.Objects.DataClasses;

namespace ProdigyProducts.BLL.Domain
{
    public interface IAccountDetail
    {
        int AccountID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        string Address { get; set; }
        string BillingAddress { get; set; }
    }

    public class AccountDetail : IAccountDetail
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
