using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProdigyProducts.BLL.Adapters;
using ProdigyProducts.BLL.Data;
using ProductDetail = ProdigyProducts.BLL.Domain.ProductDetail;

namespace ProdigyProducts.BLL.Services
{
    public class ProductDetailService : IDBOperations<Domain.ProductDetail>
    {
        private IAdapter<Data.ProductDetail, Domain.ProductDetail> _adapter = new ProductDetailAdapter();
        private Data.IRepository<Data.ProductDetail> _repository = new Repository<Data.ProductDetail>();

        public void Insert(ProductDetail domainObject)
        {
            _repository.Insert(_adapter.ConvertToDataObject(domainObject));
        }

        public void Update(ProductDetail domainObject)
        {
            _repository.Update(_adapter.ConvertToDataObject(domainObject));
        }

        public void Delete(ProductDetail domainObject)
        {
            _repository.Delete(_adapter.ConvertToDataObject(domainObject));
        }
        public ProductDetail GetProductDetailById(int id)
        {
            var productDetail = _repository.GetEntities().SingleOrDefault(w => w.product_details_id == id);
            return _adapter.ConvertToDomainObject(productDetail);
        }
        public IList<ProductDetail> GetAllProductDetails()
        {
            IList<ProductDetail> _domainItems=new List<ProductDetail>();
            var items = _repository.GetEntities();
            foreach (var productDetail in items)
            {
                _domainItems.Add(_adapter.ConvertToDomainObject(productDetail));
            }
            return _domainItems;
        }
    }
}

  