using ProdigyProducts.BLL.Domain;

namespace ProdigyProducts.BLL.Adapters
{
    public class OrderAdapter : IAdapter<Data.Order,Domain.Order>
    {
        public Order ConvertToDomainObject(Data.Order dataObject)
        {
            Domain.Order order=new Order();
            order.OrderID = dataObject.order_id;
            order.ShipppingAddress = dataObject.Shipping_address;
            order.Total = dataObject.total;
            order.Tax =  dataObject.tax;
            order.BillingAddress = dataObject.billing_address;
            order.AccountID = dataObject.account_id;
            order.OrderDate = dataObject.order_date;
            order.OrderStatus = dataObject.order_status;
            return order;


        }

        public Data.Order ConvertToDataObject(Order domainObject)
        {
            Data.Order order= new Data.Order();
            order.order_id = domainObject.OrderID;
            order.Shipping_address = domainObject.ShipppingAddress;
            order.total = domainObject.Total;
            order.tax = domainObject.Tax;
            order.billing_address = domainObject.BillingAddress;
            order.account_id = domainObject.AccountID;
            order.order_date = domainObject.OrderDate;
            order.order_status = domainObject.OrderStatus;
            return order;
        }

        public void UpdateDataObject(Order domainObject, ref Data.Order dataObject)
        {
           
            dataObject.Shipping_address = domainObject.ShipppingAddress;
            dataObject.total =domainObject.Total;
            dataObject.tax = domainObject.Tax;
            dataObject.billing_address = domainObject.BillingAddress;
            dataObject.account_id = domainObject.AccountID;
            dataObject.order_date = domainObject.OrderDate;
            dataObject.order_status = domainObject.OrderStatus;

        }
    }
}
