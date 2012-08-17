using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProdigyProducts.BLL.Adapters;
using ProdigyProducts.BLL.Data;
using ProductRating = ProdigyProducts.BLL.Domain.ProductRating;

namespace ProdigyProducts.BLL.Services
{
   public class ProductRatingService: IDBOperations<Domain.ProductRating>
   {
        IAdapter<Data.ProductRating, Domain.ProductRating> _adapter = new ProductRatingAdapter();
       Data.IRepository<Data.ProductRating>_repository=new Repository<Data.ProductRating>();
       
       public void Insert(ProductRating domainObject)
       {
           _repository.Insert(_adapter.ConvertToDataObject(domainObject));
       }

       public void Update(ProductRating domainObject)
       {
           _repository.Update(_adapter.ConvertToDataObject(domainObject));
       }

       public void Delete(ProductRating domainObject)
       {
           _repository.Delete(_adapter.ConvertToDataObject(domainObject));
       }
       public ProductRating GetProductRatingById(int id)
       {
           var productRating = _repository.GetEntities().SingleOrDefault(w => w.rate_id == id);
           return _adapter.ConvertToDomainObject(productRating);
       }
       public  IList<ProductRating> GetAllProductRatings()
       {
           IList<ProductRating>_domainItems=new List<ProductRating>();
           var items = _repository.GetEntities();
           foreach (var productRating in items)
           {
               _domainItems.Add(_adapter.ConvertToDomainObject(productRating));
           }
           return _domainItems;
       }
   }
}
