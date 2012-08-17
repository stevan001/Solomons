using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProdigyProducts.BLL.Adapters;
using ProdigyProducts.BLL.Data;
using ProductTypeAttribute = ProdigyProducts.BLL.Domain.ProductTypeAttribute;

namespace ProdigyProducts.BLL.Services
{
    public class ProductTypeAttributeService : IDBOperations<Domain.ProductTypeAttribute>
    {
        private IAdapter<Data.ProductTypeAttribute, Domain.ProductTypeAttribute> _adapter =
            new ProductTypeAttributeAdapter();

        private Data.IRepository<Data.ProductTypeAttribute> _repository = new Repository<Data.ProductTypeAttribute>();

        public void Insert(ProductTypeAttribute domainObject)
        {
            _repository.Insert(_adapter.ConvertToDataObject(domainObject));
        }

        public void Update(ProductTypeAttribute domainObject)
        {
            _repository.Update(_adapter.ConvertToDataObject(domainObject));
        }

        public void Delete(ProductTypeAttribute domainObject)
        {
            _repository.Delete(_adapter.ConvertToDataObject(domainObject));
        }
        public ProductTypeAttribute GetProductTypeAttributeById(int id)
        {
            var productTypeAttribute = _repository.GetEntities().SingleOrDefault(w => w.attribute_id == id);
            return _adapter.ConvertToDomainObject(productTypeAttribute);
        }
        public IList<ProductTypeAttribute> GetAllProductTypeAttributes()
        {
            IList<ProductTypeAttribute> _domainItems = new List<ProductTypeAttribute>();
            var items = _repository.GetEntities();
            foreach (var productTypeAttribute in items)
            {
                _domainItems.Add(_adapter.ConvertToDomainObject(productTypeAttribute));
            }
            return _domainItems;

        }
    }
}
 