using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProdigyProducts.BLL.Adapters;
using ProdigyProducts.BLL.Data;
using OrderDetail = ProdigyProducts.BLL.Domain.OrderDetail;

namespace ProdigyProducts.BLL.Services
{
    public class OrderDetailService: IDBOperations<Domain.OrderDetail>
    {
        IAdapter<Data.OrderDetail,Domain.OrderDetail>_adapter=new OrderDetailAdapter();
        Data.IRepository<Data.OrderDetail>_repository=new Repository<Data.OrderDetail>();


        public void Insert(OrderDetail domainObject)
        {
            _repository.Insert(_adapter.ConvertToDataObject(domainObject));
        }

        public void Update(OrderDetail domainObject)
        {
            _repository.Update(_adapter.ConvertToDataObject(domainObject));
        }

        public void Delete(OrderDetail domainObject)
        {
           _repository.Delete(_adapter.ConvertToDataObject(domainObject));
        }

        public OrderDetail GetOrderDetailById(int id)
        {
            var orderDetail = _repository.GetEntities().SingleOrDefault(w => w.order_id == id);
            return _adapter.ConvertToDomainObject(orderDetail);
        }

        public IList<OrderDetail> GetAllOrderDetails()
        {
            IList<OrderDetail> _domainItems = new List<OrderDetail>();
            var items = _repository.GetEntities();
            foreach (var orderDetail in items)
            {
                _domainItems.Add(_adapter.ConvertToDomainObject(orderDetail));
            }
            return _domainItems;
        }
    }

}
