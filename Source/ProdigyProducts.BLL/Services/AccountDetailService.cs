using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProdigyProducts.BLL.Adapters;
using ProdigyProducts.BLL.Data;
using ProdigyProducts.BLL.Domain;
using AccountDetail = ProdigyProducts.BLL.Domain.AccountDetail;

namespace ProdigyProducts.BLL.Services
{
    public interface IAccountDetailService : IDBOperations<IAccountDetail>
    {
        void Insert(IAccountDetail domainObject);
        void Update(IAccountDetail domainObject);
        void Delete(IAccountDetail domainObject);
        IAccountDetail GetAccountDetailById(int id);
        IList<IAccountDetail> GetAllAccountDetails();
    }

    public class AccountDetailService: IAccountDetailService
    {
       IAdapter<Data.AccountDetail,Domain.IAccountDetail>_adapter=new AccountDetailAdapter();
       Data.IRepository<Data.AccountDetail>_repository=new Repository<Data.AccountDetail>();

       public void Insert(IAccountDetail domainObject)
       {
           _repository.Insert(_adapter.ConvertToDataObject(domainObject));
       }

       public void Update(IAccountDetail domainObject)
       {
           _repository.Update(_adapter.ConvertToDataObject(domainObject));
       }

       public  void Delete(IAccountDetail domainObject)
       {

           var obj = GetAccountDetailById(domainObject.AccountID);
           if (obj == null)
               return; 

          _repository.Delete(_adapter.ConvertToDataObject(domainObject));
       }
       public IAccountDetail GetAccountDetailById(int id)
       {
           var accountDetail = _repository.GetEntities().SingleOrDefault(w => w.account_id == id);
           return _adapter.ConvertToDomainObject(accountDetail);
       }

       public IList<IAccountDetail> GetAllAccountDetails()
       {
           IList<IAccountDetail>_domainItems=new List<IAccountDetail>();
           var items = _repository.GetEntities();
           foreach (var accountDetail in items)
           {
               _domainItems.Add(_adapter.ConvertToDomainObject(accountDetail));
           }

           return _domainItems;


       }
       }

   }

