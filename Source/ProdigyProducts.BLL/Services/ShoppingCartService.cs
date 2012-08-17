using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProdigyProducts.BLL.Adapters;
using ProdigyProducts.BLL.Data;
using ShoppingCart = ProdigyProducts.BLL.Domain.ShoppingCart;

namespace ProdigyProducts.BLL.Services
{
   public class ShoppingCartService: IDBOperations<Domain.ShoppingCart>
   {
       IAdapter<Data.ShoppingCart,Domain.ShoppingCart>_adapter=new ShoppingCartAdapter();
       Data.IRepository<Data.ShoppingCart>_repository=new Repository<Data.ShoppingCart>();
       public void Insert(ShoppingCart domainObject)
       {
           _repository.Insert(_adapter.ConvertToDataObject(domainObject));
       }

       public void Update(ShoppingCart domainObject)
       {
           _repository.Update(_adapter.ConvertToDataObject(domainObject));
       }

       public void Delete(ShoppingCart domainObject)
       {
           _repository.Delete(_adapter.ConvertToDataObject(domainObject));
       }
       public ShoppingCart GetShoppingCartById(int id)
       {
           var shoppingCart = _repository.GetEntities().SingleOrDefault(w => w.cart_id == id);
           return _adapter.ConvertToDomainObject(shoppingCart);
       }
       public IList<ShoppingCart> GetAllShoppingCart()
       {
           IList<ShoppingCart>_domainItems=new List<ShoppingCart>();
           var items = _repository.GetEntities();
           foreach (var shoppingCart in items)
           {
               _domainItems.Add(_adapter.ConvertToDomainObject(shoppingCart));
           }
           return _domainItems;
       }
   }
}
