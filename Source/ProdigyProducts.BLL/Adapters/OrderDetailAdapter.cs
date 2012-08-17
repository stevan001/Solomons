using ProdigyProducts.BLL.Domain;

namespace ProdigyProducts.BLL.Adapters
{
    public class OrderDetailAdapter: IAdapter<Data.OrderDetail,Domain.OrderDetail>
    {
        public OrderDetail ConvertToDomainObject(Data.OrderDetail dataObject)
        {
            Domain.OrderDetail orderDetail=new OrderDetail();
            orderDetail.DetailID = dataObject.detail_id;
            orderDetail.OrderID = dataObject.order_id;
            orderDetail.ProductID = dataObject.product_id;
            orderDetail.Price = dataObject.price;
            orderDetail.Quantity = dataObject.quantity;
            orderDetail.TotalItemPrice = dataObject.total_item_price;
            return orderDetail; 
        }

        public Data.OrderDetail ConvertToDataObject(OrderDetail domainObject)
        {
            Data.OrderDetail orderDetail=new Data.OrderDetail();
            orderDetail.detail_id = domainObject.DetailID;
            orderDetail.order_id = domainObject.OrderID;
            orderDetail.product_id = domainObject.ProductID;
            orderDetail.price = domainObject.Price;
            orderDetail.quantity = domainObject.Quantity;
            orderDetail.total_item_price = domainObject.TotalItemPrice;
            return orderDetail; 
        }

        public void UpdateDataObject(OrderDetail domainObject, ref Data.OrderDetail dataObject)
        {
            dataObject.detail_id = domainObject.DetailID;
            dataObject.order_id = domainObject.OrderID;
            dataObject.product_id = domainObject.ProductID;
            dataObject.price = domainObject.Price;
            dataObject.quantity = domainObject.Quantity;
            dataObject.total_item_price = domainObject.TotalItemPrice;
        }
    }
}
