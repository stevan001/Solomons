using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProdigyProducts.BLL.Adapters;
using ProdigyProducts.BLL.Data;
using WishListDetail = ProdigyProducts.BLL.Domain.WishListDetail;

namespace ProdigyProducts.BLL.Services
{
   public class WishListDetailService :IDBOperations<Domain.WishListDetail>
   {
       IAdapter<Data.WishListDetail,Domain.WishListDetail>_adapter=new WishListDetailAdapter();
       Data.IRepository<Data.WishListDetail>_repository=new Repository<Data.WishListDetail>();
       public void Insert(WishListDetail domainObject)
       {
           _repository.Insert(_adapter.ConvertToDataObject(domainObject));
       }

       public void Update(WishListDetail domainObject)
       {

           var dbObject = _repository.GetEntities().SingleOrDefault(d => d.wish_list_id == domainObject.WishListId); 
           if (dbObject!= null)
           {
               _repository.Update(_adapter.ConvertToDataObject(domainObject));    
           }
           
       }

       public void Delete(WishListDetail domainObject)
       {
              var dbObject = _repository.GetEntities().SingleOrDefault(d => d.wish_list_id == domainObject.WishListId);
              if (dbObject != null)
              {
                  _repository.Delete(_adapter.ConvertToDataObject(domainObject));
              }
       }
       public WishListDetail GetWishListDetailById(int id)
       {
           var wishListDetail = _repository.GetEntities().SingleOrDefault(w => w.wish_list_details_id == id);
           return _adapter.ConvertToDomainObject(wishListDetail);
       }
       public IList<WishListDetail> GetAllWishListDetails()
       {
           IList<WishListDetail>_domainItems=new List<WishListDetail>();
           var item = _repository.GetEntities();
           foreach (var wishListDetail in item)
           {
               _domainItems.Add(_adapter.ConvertToDomainObject(wishListDetail));
           }
           return _domainItems;

       }
       
   }
}
