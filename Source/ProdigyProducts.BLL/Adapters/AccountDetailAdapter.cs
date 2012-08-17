using ProdigyProducts.BLL.Domain;

namespace ProdigyProducts.BLL.Adapters
{
    public class AccountDetailAdapter : IAdapter<Data.AccountDetail,Domain.AccountDetail>

    {
        public Domain.AccountDetail ConvertToDomainObject(Data.AccountDetail dataObject)
        {
            Domain.AccountDetail accountDetail= new AccountDetail();
            accountDetail.AccountID = dataObject.account_id;
            accountDetail.Address = dataObject.address;
            accountDetail.BillingAddress = dataObject.billing_address;
            accountDetail.Email = dataObject.email;
            accountDetail.FirstName = dataObject.first_name;
            accountDetail.LastName = dataObject.last_name;
            accountDetail.PhoneNumber = dataObject.phone;
            return accountDetail;
        }

        public Data.AccountDetail ConvertToDataObject(Domain.AccountDetail domainObject)
        {
           Data.AccountDetail accountDetail = new Data.AccountDetail();
            accountDetail.account_id = domainObject.AccountID;
            accountDetail.address = domainObject.Address;
            accountDetail.billing_address = domainObject.BillingAddress;
            accountDetail.email = domainObject.Email;
            accountDetail.first_name = domainObject.FirstName;
            accountDetail.last_name = domainObject.LastName;
            accountDetail.phone = domainObject.PhoneNumber;
            return accountDetail;
        }

        public void UpdateDataObject(Domain.AccountDetail domainObject, ref Data.AccountDetail dataObject)
        {
            dataObject.account_id = domainObject.AccountID;
            dataObject.address = domainObject.Address;
            dataObject.billing_address = domainObject.BillingAddress;
            dataObject.email = domainObject.Email;
            dataObject.first_name = domainObject.FirstName;
            dataObject.last_name = domainObject.LastName;
            dataObject.phone = domainObject.PhoneNumber;
        }
    }
}
