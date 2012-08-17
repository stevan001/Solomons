using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProdigyProducts.BLL.Adapters;
using ProdigyProducts.BLL.Data;
using ProductCategory = ProdigyProducts.BLL.Domain.ProductCategory;

namespace ProdigyProducts.BLL.Services
{
    public class ProductCategoryService : IDBOperations<Domain.ProductCategory>
    {
        private IAdapter<Data.ProductCategory, Domain.ProductCategory> _adapter = new ProductCategoryAdapter();
        private Data.IRepository<Data.ProductCategory> _repository = new Repository<Data.ProductCategory>();

        public void Insert(ProductCategory domainObject)
        {
            _repository.Insert(_adapter.ConvertToDataObject(domainObject));
        }

        public void Update(ProductCategory domainObject)
        {
            _repository.Update(_adapter.ConvertToDataObject(domainObject));
        }

        public void Delete(ProductCategory domainObject)
        {
            _repository.Delete(_adapter.ConvertToDataObject(domainObject));


        }

        public ProductCategory GetProductCategoryById(int id)
        {
            var productCategory = _repository.GetEntities().SingleOrDefault(w => w.category_id == id);
            return _adapter.ConvertToDomainObject(productCategory);
        }

        public IList<ProductCategory> GetAllProductCategory()
        {
            IList<ProductCategory> _domainItems = new List<ProductCategory>();
            var items = _repository.GetEntities();
            foreach (var productCategory in items)
            {
                _domainItems.Add(_adapter.ConvertToDomainObject(productCategory));
            }
            return _domainItems;
        }
    }
}
