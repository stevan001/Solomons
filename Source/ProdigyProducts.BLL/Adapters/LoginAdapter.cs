using ProdigyProducts.BLL.Domain;

namespace ProdigyProducts.BLL.Adapters
{
    public class LoginAdapter : IAdapter<Data.Login, Domain.ILogin>
    {
        public ILogin ConvertToDomainObject(Data.Login dataObject)
        {
            Domain.Login login = new Login();
            login.Email = dataObject.email;
            login.Registered = dataObject.registered;
            login.RegistrationCode = dataObject.registration_code;
            login.IsAdmin = dataObject.is_admin; 
            //login.Password = dataObject.password; 
            return login; 
        }

        public Data.Login ConvertToDataObject(ILogin domainObject)
        {
            Data.Login login = new Data.Login();
            login.email = domainObject.Email;
            login.password = domainObject.Password;
            login.registered = domainObject.Registered;
            login.registration_code = domainObject.RegistrationCode; 
            return login;
        }

        public void UpdateDataObject(ILogin domainObject, ref Data.Login dataObject)
        {
            //dataObject.email = domainObject.Email; 
            dataObject.registration_code = domainObject.RegistrationCode;
            dataObject.registered = domainObject.Registered;
            if (!string.IsNullOrEmpty(domainObject.Password))
            {
                dataObject.password = domainObject.Password; 
            }
        }
    }
}