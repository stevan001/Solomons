using ProdigyProducts.BLL.Data;
using ProdigyProducts.BLL.Domain;

namespace ProdigyProducts.BLL.Adapters
{
    public class OrderStatusAdapter : IAdapter<Data.Order_status, Domain.OrderStatus>
    {
        public OrderStatus ConvertToDomainObject(Order_status dataObject)
        {
            Domain.OrderStatus orderStatus = new OrderStatus();
            orderStatus.OrderStatusID = dataObject.order_status_id;
            orderStatus.OrdeStatus = dataObject.order_status;
            return orderStatus; 

        }

        public Order_status ConvertToDataObject(OrderStatus domainObject)
        {
            Data.Order_status orderStatus = new Order_status();
            orderStatus.order_status_id = domainObject.OrderStatusID;
            orderStatus.order_status = domainObject.OrdeStatus;
            return orderStatus; 
        }

        public void UpdateDataObject(OrderStatus domainObject, ref Order_status dataObject)
        {
            dataObject.order_status = domainObject.OrdeStatus;
            dataObject.order_status_id = domainObject.OrderStatusID;
        }
    }

}