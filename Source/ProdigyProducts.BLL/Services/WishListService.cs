using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProdigyProducts.BLL.Adapters;
using ProdigyProducts.BLL.Data;
using WishList = ProdigyProducts.BLL.Domain.WishList;

namespace ProdigyProducts.BLL.Services
{
   public class WishListService:IDBOperations<Domain.WishList>
   {
       IAdapter<Data.WishList,Domain.WishList>_adapter=new WishListAdapter();
       Data.IRepository<Data.WishList>_repository=new Repository<Data.WishList>();
       public void Insert(WishList domainObject)
       {
           _repository.Insert(_adapter.ConvertToDataObject(domainObject));
       }

       public void Update(WishList domainObject)
       {
           _repository.Update(_adapter.ConvertToDataObject(domainObject));
       }

       public void Delete(WishList domainObject)
       {
          _repository.Delete(_adapter.ConvertToDataObject(domainObject));
       }


       public WishList GetWishListById(int id )
       {
           var wishList = _repository.GetEntities().SingleOrDefault(w => w.wish_list_id == id);
           return _adapter.ConvertToDomainObject(wishList);
       }

       public IList<WishList> GetAllWishLists()
       {
           IList<WishList> _domainItems = new List<WishList>();
           var items = _repository.GetEntities();
           foreach (var wishList in items)
           {
               _domainItems.Add(_adapter.ConvertToDomainObject(wishList));
           }
           return _domainItems;

       } 
   }
}
