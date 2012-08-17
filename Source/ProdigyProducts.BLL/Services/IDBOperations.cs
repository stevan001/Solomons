namespace ProdigyProducts.BLL.Services
{
    public interface IDBOperations<T>
    {
       
        void Insert(T domainObject);
        void Update(T domainObject);
        void Delete(T domainObject);
        
    }
}