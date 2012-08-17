using System.Collections.Generic;
using ProdigyProducts.BLL.Data;
using ProdigyProducts.BLL.Adapters;
using System.Linq;
using System.Data;
using Login = ProdigyProducts.BLL.Domain.Login;

namespace ProdigyProducts.BLL.Services
{
    public class LoginService : IDBOperations<Domain.Login>
    {

        IAdapter<Data.Login,Domain.Login> _adapter = new LoginAdapter();
        Data.IRepository<Data.Login> _repository = new Repository<Data.Login>(); 

        public void Insert(Login domainObject)
        {
            _repository.Insert(_adapter.ConvertToDataObject(domainObject));
        }

        public void Update(Login domainObject)
        {
           _repository.Update(_adapter.ConvertToDataObject(domainObject));
        }

        public void Delete(Login domainObject)
        {
            _repository.Delete(_adapter.ConvertToDataObject(domainObject));
        }

        public IList<Domain.Login> GetLogins()
        {
            IList<Domain.Login> _login = new List<Login>();
            var query = _repository.GetEntities();
            foreach (var login in query)
            {
                
            }

            return null; 
        }
    }
}