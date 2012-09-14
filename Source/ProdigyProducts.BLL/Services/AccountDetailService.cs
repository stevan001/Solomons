using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProdigyProducts.BLL.Adapters;
using ProdigyProducts.BLL.Data;
using AccountDetail = ProdigyProducts.BLL.Domain.AccountDetail;

namespace ProdigyProducts.BLL.Services
{
   public class AccountDetailService:IDBOperations<Domain.AccountDetail>
   {
       IAdapter<Data.AccountDetail,Domain.AccountDetail>_adapter=new AccountDetailAdapter();
       Data.IRepository<Data.AccountDetail>_repository=new Repository<Data.AccountDetail>();

       public void Insert(AccountDetail domainObject)
       {
           _repository.Insert(_adapter.ConvertToDataObject(domainObject));
       }

       public void Update(AccountDetail domainObject)
       {
           _repository.Update(_adapter.ConvertToDataObject(domainObject));
       }

       public  void Delete(AccountDetail domainObject)
       {

           var obj = GetAccountDetailById(domainObject.AccountID);
           if (obj == null)
               return; 

          _repository.Delete(_adapter.ConvertToDataObject(domainObject));
       }
       public AccountDetail GetAccountDetailById(int id)
       {
           var accountDetail = _repository.GetEntities().SingleOrDefault(w => w.account_id == id);
           return _adapter.ConvertToDomainObject(accountDetail);
       }

       public IList<AccountDetail> GetAllAccountDetails()
       {
           IList<AccountDetail>_domainItems=new List<AccountDetail>();
           var items = _repository.GetEntities();
           foreach (var accountDetail in items)
           {
               _domainItems.Add(_adapter.ConvertToDomainObject(accountDetail));
           }

           return _domainItems;


       }
       }

   }

