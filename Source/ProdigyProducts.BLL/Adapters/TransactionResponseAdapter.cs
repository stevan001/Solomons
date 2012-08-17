namespace ProdigyProducts.BLL.Adapters
{
   public class TransactionResponseAdapter:IAdapter<Data.TransactionResponse,Domain.TransactionResponse>
   {
       public Domain.TransactionResponse ConvertToDomainObject(Data.TransactionResponse dataObject)
       {
           Domain.TransactionResponse transactionResponse=new Domain.TransactionResponse();
           transactionResponse.ResponseId = dataObject.response_id;
           transactionResponse.ResponseDetail = dataObject.response_details;
           transactionResponse.RequestUniqueIdentifier = dataObject.request_unique_identifier;
           transactionResponse.DataReceived = dataObject.data_received;
           return transactionResponse; 

       }

       public Data.TransactionResponse ConvertToDataObject(Domain.TransactionResponse domainObject)
       {
           Data.TransactionResponse transactionResponse=new Data.TransactionResponse();
           transactionResponse.response_id = domainObject.ResponseId;
           transactionResponse.response_details = domainObject.ResponseDetail;
           transactionResponse.request_unique_identifier = domainObject.RequestUniqueIdentifier;
           transactionResponse.data_received = domainObject.DataReceived;
           return transactionResponse; 
       }

       public void UpdateDataObject(Domain.TransactionResponse domainObject, ref Data.TransactionResponse dataObject)
       {
           dataObject.response_details = domainObject.ResponseDetail;
           dataObject.data_received = domainObject.DataReceived;
       }
   }
}
