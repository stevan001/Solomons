using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProdigyProducts.BLL.Adapters;
using ProdigyProducts.BLL.Data;
using TransactionRequest = ProdigyProducts.BLL.Domain.TransactionRequest;

namespace ProdigyProducts.BLL.Services
{
   public class TransactionRequestService : IDBOperations<Domain.TransactionRequest>
   {
       IAdapter<Data.TransactionRequest,Domain.TransactionRequest>_adapter=new TransactionRequestAdapter();
       Data.IRepository<Data.TransactionRequest>_repository=new Repository<Data.TransactionRequest>();
       public void Insert(TransactionRequest domainObject)
       {
           _repository.Insert(_adapter.ConvertToDataObject(domainObject));
       }

       public void Update(TransactionRequest domainObject)
       {
           _repository.Update(_adapter.ConvertToDataObject(domainObject));
       }

       public void Delete(TransactionRequest domainObject)
       {
           _repository.Delete(_adapter.ConvertToDataObject(domainObject));
       }
       public TransactionRequest GetTransactionRequestById(int id)
       {
           var transactionRequest = _repository.GetEntities().SingleOrDefault(w => w.request_id == id);
           return _adapter.ConvertToDomainObject(transactionRequest);
       }

       public IList<TransactionRequest> GetAllTransactionRequest()
       {
           IList<TransactionRequest>_domainItems=new List<TransactionRequest>();
           var items = _repository.GetEntities();
           foreach (var transactionRequest in items)
           {
               _domainItems.Add(_adapter.ConvertToDomainObject(transactionRequest));
           }
           return _domainItems;
       }

   }
}
