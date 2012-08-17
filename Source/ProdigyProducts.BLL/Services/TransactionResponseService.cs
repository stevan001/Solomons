using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProdigyProducts.BLL.Adapters;
using ProdigyProducts.BLL.Data;
using TransactionResponse = ProdigyProducts.BLL.Domain.TransactionResponse;

namespace ProdigyProducts.BLL.Services
{
   public class TransactionResponseService :IDBOperations<Domain.TransactionResponse>
   {
       IAdapter<Data.TransactionResponse,Domain.TransactionResponse>_adapter=new TransactionResponseAdapter();
       Data.IRepository<Data.TransactionResponse>_repository=new Repository<Data.TransactionResponse>();
       public void Insert(TransactionResponse domainObject)
       {
           _repository.Insert(_adapter.ConvertToDataObject(domainObject));
       }

       public void Update(TransactionResponse domainObject)
       {
           _repository.Update(_adapter.ConvertToDataObject(domainObject));
       }

       public void Delete(TransactionResponse domainObject)
       {
           _repository.Delete(_adapter.ConvertToDataObject(domainObject));
       }
       public TransactionResponse GetTransactionResponseById(int id)
       {
           var transactionResponse = _repository.GetEntities().SingleOrDefault(w => w.response_id == id);
           return _adapter.ConvertToDomainObject(transactionResponse);
       }
       public IList<Domain.TransactionResponse> GetAllTransactionResponse()
       {
           IList<Domain.TransactionResponse>_domainItems = new List<Domain.TransactionResponse>();
           var items = _repository.GetEntities();
           foreach (var transactionResponse in items)
           {
               _domainItems.Add(_adapter.ConvertToDomainObject(transactionResponse));
           }
           return _domainItems;
       }
   }
}
