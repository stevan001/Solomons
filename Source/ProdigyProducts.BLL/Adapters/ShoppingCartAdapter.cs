namespace ProdigyProducts.BLL.Adapters
{
   public class ShoppingCartAdapter:IAdapter<Data.ShoppingCart,Domain.ShoppingCart>
   {
       public Domain.ShoppingCart ConvertToDomainObject(Data.ShoppingCart dataObject)
       {
           Domain.ShoppingCart shoppingCart=new Domain.ShoppingCart();
           shoppingCart.CartId = dataObject.cart_id;
           shoppingCart.CreatedBy = dataObject.created_by;
           return shoppingCart; 
       }

       public Data.ShoppingCart ConvertToDataObject(Domain.ShoppingCart domainObject)
       {
           Data.ShoppingCart shoppingCart=new Data.ShoppingCart();
           shoppingCart.cart_id = domainObject.CartId;
           shoppingCart.created_by = domainObject.CreatedBy;
           return shoppingCart;
       }

       public void UpdateDataObject(Domain.ShoppingCart domainObject, ref Data.ShoppingCart dataObject)
       {
           dataObject.created_by = domainObject.CreatedBy;
       }
   }
}
