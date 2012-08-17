using System.Data;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.ServiceModel.DomainServices.EntityFramework;

namespace ProdigyProducts.BLL.Data
{
    public class Repository<T> :  IRepository<T> where T: EntityObject
    {

        #region Private Variables

        private readonly ObjectContext _context;
        private ObjectSet<T> _objectSet;

        #endregion

        #region Constructors

        public Repository(ObjectContext context, ObjectSet<T> objectSet)
        {
            _context = context;
            _objectSet = objectSet;
        }

        public Repository()
        {
            _context = new SolomonsEntities();
            _objectSet = _context.CreateObjectSet<T>();
        }

        #endregion

        #region Properties

        protected ObjectSet<T> ObjectSet
        {
            get { return _objectSet; }
        }

        protected ObjectContext ObjectContext
        {
            get { return _context; }

        }

        public IQueryable<T> GetEntities()
        {
            return this.ObjectSet;
        }

        #endregion

        #region Crud Operations

        public void Insert(T entity)
        {
            if (entity.EntityState != EntityState.Detached)
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(entity, EntityState.Added);
            }
            else
            {
                this.ObjectSet.AddObject(entity);
            }

            this.ObjectContext.SaveChanges();
        }



        public void Delete(T entity)
        {

            if (entity.EntityState != EntityState.Detached)
            {

                this.ObjectContext.ObjectStateManager.ChangeObjectState(entity, EntityState.Deleted);
            }
            else
            {
                this.ObjectSet.Attach(entity);
                this.ObjectSet.DeleteObject(entity);

            }
            this.ObjectContext.SaveChanges();
        }

        public void Update(T entity)
        {
            this.ObjectSet.AttachAsModified(entity);
            this.ObjectContext.SaveChanges();
        }

        #endregion

    }
}