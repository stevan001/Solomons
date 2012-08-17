using System;

namespace ProdigyProducts.BLL.Domain
{
   public class TransactionRequest
    {
       public int RequestId { get; set; }
       public string Requestdetails { get; set; }
       public string UniqueRequestId { get; set; }
       public DateTime? RequestDate { get; set; }
    }
}
