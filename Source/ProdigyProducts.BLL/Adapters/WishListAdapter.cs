using ProdigyProducts.BLL.Domain;

namespace ProdigyProducts.BLL.Adapters
{
   public class WishListAdapter: IAdapter<Data.WishList,Domain.WishList>
   {
       public WishList ConvertToDomainObject(Data.WishList dataObject)
       {
           Domain.WishList wishList=new WishList();
           wishList.WishListID = dataObject.wish_list_id;
           wishList.ListName = dataObject.list_name;
           wishList.AccountID = dataObject.account_id;
           return wishList; 
       }

       public Data.WishList ConvertToDataObject(WishList domainObject)
       {
           Data.WishList wishList=new Data.WishList();
           wishList.wish_list_id = domainObject.WishListID;
           wishList.list_name = domainObject.ListName;
           wishList.account_id = domainObject.AccountID;
           return wishList; 
       }

       public void UpdateDataObject(WishList domainObject, ref Data.WishList dataObject)
       {
           dataObject.list_name = domainObject.ListName;
           
       }
   }
}
