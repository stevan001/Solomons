using ProdigyProducts.BLL.Domain;

namespace ProdigyProducts.BLL.Adapters
{
    public class WishListDetailAdapter: IAdapter<Data.WishListDetail, Domain.WishListDetail>
    {
        public WishListDetail ConvertToDomainObject(Data.WishListDetail dataObject)
        {
            Domain.WishListDetail wishListDetail=new WishListDetail();
            wishListDetail.WishListDetailId = dataObject.wish_list_details_id;
            wishListDetail.WishListId = dataObject.wish_list_id;
            wishListDetail.ProductId = dataObject.product_id;
            return wishListDetail; 
        }

        public Data.WishListDetail ConvertToDataObject(WishListDetail domainObject)
        {
           Data.WishListDetail wishListDetail=new Data.WishListDetail();
            wishListDetail.wish_list_details_id = domainObject.WishListDetailId;
            wishListDetail.wish_list_id = domainObject.WishListId;
            wishListDetail.product_id = domainObject.ProductId;
            return wishListDetail; 
        }

        public void UpdateDataObject(WishListDetail domainObject, ref Data.WishListDetail dataObject)
        {
            
        }
    }
}
