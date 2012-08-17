using ProdigyProducts.BLL.Domain;

namespace ProdigyProducts.BLL.Adapters
{
    public class LikedproductAdapter : IAdapter<Data.Likedproduct, Domain.Likedproduct>
    {
        public Likedproduct ConvertToDomainObject(Data.Likedproduct dataObject)
        {
            Domain.Likedproduct likedproduct = new Likedproduct();
            likedproduct.LikeID = dataObject.like_id;
            likedproduct.LikeBy = dataObject.liked_by;
            likedproduct.ProductID = dataObject.product_id;
            return likedproduct; 
        }

        public Data.Likedproduct ConvertToDataObject(Likedproduct domainObject)
        {

            Data.Likedproduct likedproduct = new Data.Likedproduct();
            likedproduct.like_id = domainObject.LikeID;
            likedproduct.liked_by = domainObject.LikeBy;
            likedproduct.product_id = domainObject.ProductID;
            return likedproduct;
        }

        public void UpdateDataObject(Likedproduct domainObject, ref Data.Likedproduct dataObject)
        {
            dataObject.liked_by = domainObject.LikeBy;
        }

    }
}
