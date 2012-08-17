using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProdigyProducts.BLL.Adapters;
using ProdigyProducts.BLL.Data;
using ProdigyProducts.BLL.Domain;

namespace ProdigyProducts.BLL.Services
{
   public class OrderStatusService:IDBOperations<Domain.OrderStatus>
   {
       IAdapter<Data.Order_status,Domain.OrderStatus>_adapter=new OrderStatusAdapter();
       Data.IRepository<Data.Order_status>_repository=new Repository<Order_status>();
       public void Insert(OrderStatus domainObject)
       {
           _repository.Insert(_adapter.ConvertToDataObject(domainObject));
       }

       public void Update(OrderStatus domainObject)
       {
           _repository.Update(_adapter.ConvertToDataObject(domainObject));
       }

       public void Delete(OrderStatus domainObject)
       {
           _repository.Delete(_adapter.ConvertToDataObject(domainObject));
       }
       public OrderStatus GetOrderStatusById(int id)
       {
           var orderStatus = _repository.GetEntities().SingleOrDefault(w => w.order_status_id == id);
           return _adapter.ConvertToDomainObject(orderStatus);
       }
       public IList<OrderStatus> GetAllOrderStatus()
       {
           IList<OrderStatus>_domainItems=new List<OrderStatus>();
           var items = _repository.GetEntities();
           foreach (var orderStatuse in items)
           {
               _domainItems.Add(_adapter.ConvertToDomainObject(orderStatuse));
           }
           return _domainItems;
       } 
   }
}
