using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProdigyProducts.BLL.Adapters;
using ProdigyProducts.BLL.Data;
using Product = ProdigyProducts.BLL.Domain.Product;

namespace ProdigyProducts.BLL.Services
{
     public class ProductService: IDBOperations<Domain.Product>
     {
         IAdapter<Data.Product,Domain.Product>_adapter=new ProductAdapter();
         Data.IRepository<Data.Product>_repository=new Repository<Data.Product>();
         public void Insert(Product domainObject)
         {
             _repository.Insert(_adapter.ConvertToDataObject(domainObject));
         }

         public void Update(Product domainObject)
         {
             _repository.Update(_adapter.ConvertToDataObject(domainObject));
         }

         public void Delete(Product domainObject)
         {
            _repository.Delete(_adapter.ConvertToDataObject(domainObject));
         }
         public Product GetProductById(int id)
         {
             var product = _repository.GetEntities().SingleOrDefault(w => w.product_id == id);
             return _adapter.ConvertToDomainObject(product);
         }
         public IList<Product> GetAllProducts()
         {
             IList<Product>_domainItems=new List<Product>();
             var items = _repository.GetEntities();
             foreach (var product in items)
             {
                 _domainItems.Add(_adapter.ConvertToDomainObject(product));
             }
             return _domainItems;
         }

         public IList<Product> GetProductsById(int category)
         {
             IList<Product> domainItems = new List<Product>();
             var items = _repository.GetEntities().Where(p=>p.category_id==category);
             foreach (var product in items)
             {
                 domainItems.Add(_adapter.ConvertToDomainObject(product));
             }
             return domainItems;
         }
     }
}
