namespace ProdigyProducts.BLL.Adapters
{
   public class TransactionRequestAdapter:IAdapter<Data.TransactionRequest,Domain.TransactionRequest>
   {
       public Domain.TransactionRequest ConvertToDomainObject(Data.TransactionRequest dataObject)
       {
           Domain.TransactionRequest transactionRequest=new Domain.TransactionRequest();
           transactionRequest.RequestId = dataObject.request_id;
           transactionRequest.Requestdetails = dataObject.request_details;
           transactionRequest.RequestDate = dataObject.request_date;
           transactionRequest.UniqueRequestId = dataObject.unique_request_id;
           return transactionRequest; 
       }

       public Data.TransactionRequest ConvertToDataObject(Domain.TransactionRequest domainObject)
       {
           Data.TransactionRequest transactionRequest=new Data.TransactionRequest();
           transactionRequest.request_id = domainObject.RequestId;
           transactionRequest.request_details = domainObject.Requestdetails;
           transactionRequest.request_date = domainObject.RequestDate;
           transactionRequest.unique_request_id = domainObject.UniqueRequestId;
           return transactionRequest;
       }

       public void UpdateDataObject(Domain.TransactionRequest domainObject, ref Data.TransactionRequest dataObject)
       {
           dataObject.request_date = domainObject.RequestDate;
           dataObject.request_details = domainObject.Requestdetails;
       }
   }
}
