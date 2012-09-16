using System;
using System.Collections.Generic;
using System.Linq;
using ProdigyProducts.BLL.Adapters;
using ProdigyProducts.BLL.Data;
using ProdigyProducts.BLL.Domain;
using Login = ProdigyProducts.BLL.Domain.Login;

namespace ProdigyProducts.BLL.Services
{
    public interface ILoginService : IDBOperations<ILogin>
    {
        void Insert(ILogin domainObject);
        void Update(ILogin domainObject);
        void Delete(ILogin domainObject);
        IList<ILogin> GetLogins();
        bool Authenticate(string username, string password);
        void Register(string code);
        void AlreadyRegisterd(ILogin login);
        string GenerateRegistrationCode();
        ILogin GetLoginViaCode(string code);
    }

    public class LoginService : ILoginService
    {
        private readonly IAdapter<Data.Login, ILogin> _adapter = new LoginAdapter();
        private readonly IRepository<Data.Login> _repository = new Repository<Data.Login>();

        #region ILoginService Members

        public void Insert(ILogin domainObject)
        {
            _repository.Insert(_adapter.ConvertToDataObject(domainObject));
        }

        public void Update(ILogin domainObject)
        {
            var login = GetLogin(domainObject.Email); 
            if (login!=null)
                _repository.Update(_adapter.ConvertToDataObject(domainObject));
        }

        public void Delete(ILogin domainObject)
        {
            if (domainObject == null)
                return;
            Data.Login login = _repository.GetEntities().SingleOrDefault(s => s.email == domainObject.Email);
            if (login != null)
            {
                _repository.Delete(_adapter.ConvertToDataObject(domainObject));
            }
        }

        public IList<ILogin> GetLogins()
        {
            IList<ILogin> _login = new List<ILogin>();
            IQueryable<Data.Login> query = _repository.GetEntities();
            foreach (Data.Login login in query)
            {
            }

            return null;
        }

        public bool Authenticate(string username, string password)
        {
            var login = GetLogin(username);
            if (login == null)
                return false;

            return true;
        }

     

        private Data.Login GetLogin(string username)
        {

            Data.Login login =
                _repository.GetEntities().SingleOrDefault(
                    l => l.email == username);
            return login;
        }

        public void Register(string code)
        {
            var login = GetLoginViaCode(code);
            AlreadyRegisterd(login);
            if (login!=null)
            {
               
                login.Registered = true;
                Data.Login dataLogin = GetLogin(login.Email);
                _adapter.UpdateDataObject(login, ref dataLogin);
                _repository.Update(dataLogin);
              
            }
            
        }

        public  void AlreadyRegisterd(ILogin login)
        {
           

            if (login.Registered != null && login.Registered == true)
                throw new ApplicationException("Account is already Registered");
        }

        public ILogin GetLoginViaCode(string code)
        {
            Data.Login login =
                _repository.GetEntities().SingleOrDefault(
                    l => l.registration_code == code);
            return _adapter.ConvertToDomainObject(login) ;
        }

        #endregion

        public string GenerateRegistrationCode()
        {
            return Guid.NewGuid().ToString();
        }
    }
}