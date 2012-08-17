namespace ProdigyProducts.BLL.Adapters
{
    public interface IAdapter<T,K>
    {
         K ConvertToDomainObject(T dataObject);
         T ConvertToDataObject(K domainObject);
        void UpdateDataObject(K domainObject, ref T dataObject);


     
    }
}