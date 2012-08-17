using ProdigyProducts.BLL.Domain;

namespace ProdigyProducts.BLL.Adapters
{
    public class LoginAdapter : IAdapter<Data.Login, Domain.Login>
    {
        public Login ConvertToDomainObject(Data.Login dataObject)
        {
            Domain.Login login = new Login();
            login.Email = dataObject.email;
            //login.Password = dataObject.password; 
            return login; 
        }

        public Data.Login ConvertToDataObject(Login domainObject)
        {
            Data.Login login = new Data.Login();
            login.email = domainObject.Email;
            login.password = domainObject.Password;
            return login;
        }

        public void UpdateDataObject(Login domainObject, ref Data.Login dataObject)
        {
            dataObject.email = domainObject.Email; 
            if (!string.IsNullOrEmpty(domainObject.Password))
            {
                dataObject.password = domainObject.Password; 
            }
        }
    }
}