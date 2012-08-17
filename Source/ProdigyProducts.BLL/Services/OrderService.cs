using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProdigyProducts.BLL.Adapters;
using ProdigyProducts.BLL.Data;
using Order = ProdigyProducts.BLL.Domain.Order;

namespace ProdigyProducts.BLL.Services
{
    public class OrderService: IDBOperations<Domain.Order>
       
    {
         IAdapter<Data.Order,Domain.Order>_adapter=new OrderAdapter();
       Data.IRepository<Data.Order>_repository=new Repository<Data.Order>();


        public void Insert(Order domainObject)
        {
          _repository.Insert(_adapter.ConvertToDataObject(domainObject));
        }

        public void Update(Order domainObject)
        {
            _repository.Update(_adapter.ConvertToDataObject(domainObject));
        }

        public void Delete(Order domainObject)
        {
            _repository.Delete(_adapter.ConvertToDataObject(domainObject));
        }
        
        public Order GetOrderById(int id)

        {
            var order = _repository.GetEntities().SingleOrDefault(w => w.order_id == id);
            return _adapter.ConvertToDomainObject(order);
        }
        public IList<Order>GetAllOrders()
        {
            IList<Order>_domainItems=new List<Order>();
            var items = _repository.GetEntities();
            foreach (var order in items)
            {
                _domainItems.Add(_adapter.ConvertToDomainObject(order));
            }
            return _domainItems;
        }
    }
}
