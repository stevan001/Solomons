using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProdigyProducts.BLL.Adapters;
using ProdigyProducts.BLL.Data;
using Likedproduct = ProdigyProducts.BLL.Domain.Likedproduct;

namespace ProdigyProducts.BLL.Services
{
   public class LikedproductService:IDBOperations<Domain.Likedproduct>
   {
       IAdapter<Data.Likedproduct,Domain.Likedproduct>_adapter=new LikedproductAdapter();
       Data.IRepository<Data.Likedproduct>_repository=new Repository<Data.Likedproduct>(); 

       public void Insert(Likedproduct domainObject)
       {
           _repository.Insert(_adapter.ConvertToDataObject(domainObject));
       }

       public void Update(Likedproduct domainObject)
       {
           _repository.Update(_adapter.ConvertToDataObject(domainObject));
       }

       public void Delete(Likedproduct domainObject)
       {
           _repository.Delete(_adapter.ConvertToDataObject(domainObject));
       }
       public Likedproduct GetLikedProductById(int id)
       {
           var likedProdcut = _repository.GetEntities().SingleOrDefault((w => w.like_id == id));
           return _adapter.ConvertToDomainObject(likedProdcut);
       }

       public  IList<Likedproduct> GetAllLikedProducts()
       {
           IList<Likedproduct>_domainIteems=new List<Likedproduct>();
           var items = _repository.GetEntities();
           foreach (var likedproduct in items)
           {
               _domainIteems.Add(_adapter.ConvertToDomainObject(likedproduct));



           }
           return _domainIteems;
       }
   }
}
