using System.Linq;

namespace ProdigyProducts.BLL.Data
{
    public interface IRepository<T>
    {
        IQueryable<T> GetEntities();
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity); 
    }
}