using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProdigyProducts.BLL.Adapters;
using ProdigyProducts.BLL.Data;
using ProductImage = ProdigyProducts.BLL.Domain.ProductImage;

namespace ProdigyProducts.BLL.Services
{
  public  class ProductImageService:IDBOperations<Domain.ProductImage>
  {
      IAdapter<Data.ProductImage,Domain.ProductImage>_adapter=new ProductImageAdapter();
      Data.IRepository<Data.ProductImage>_repository=new Repository<Data.ProductImage>();
      public void Insert(ProductImage domainObject)
      {
          _repository.Insert(_adapter.ConvertToDataObject(domainObject));
      }

      public void Update(ProductImage domainObject)
      {
          _repository.Update(_adapter.ConvertToDataObject(domainObject));
      }

      public void Delete(ProductImage domainObject)
      {
          _repository.Delete(_adapter.ConvertToDataObject(domainObject));
      }
      public ProductImage GetProductImageById(int id)
      {
          var productImage = _repository.GetEntities().SingleOrDefault(w => w.image_id == id);
          return _adapter.ConvertToDomainObject(productImage);
      }
      public IList<ProductImage> GetAllProductImage()
      {
          IList<ProductImage>_domainItems=new List<ProductImage>();
          var items = _repository.GetEntities();
          foreach (var productImage in items)
          {
              _domainItems.Add(_adapter.ConvertToDomainObject(productImage));
          }
          return _domainItems;
      }
  }
}
