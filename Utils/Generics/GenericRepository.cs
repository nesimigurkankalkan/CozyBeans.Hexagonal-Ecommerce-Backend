using System.Collections.Generic;
using System.Data.Entity;

namespace Utils.Generics
{
    public interface IGenericRepository<T> where T : class
    {
        void Create(T entity);
        T ReadById(object entityKey);
        IEnumerable<T> ReadAll();
        void Update(T entity);
        void Delete(T entity);
    }
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbContext _db;
        protected readonly DbSet<T> _set;

        protected GenericRepository(DbContext dbContext)
        {
            _db = dbContext;
            _set = _db.Set<T>();
        }

        public void Create(T entity)
        {
            _set.Add(entity);
        }

        public void Delete(T entity)
        {
            _set.Remove(entity);
        }

        public IEnumerable<T> ReadAll()
        {
            return _set;
        }

        public T ReadById(object entityKey)
        {
            return _set.Find(entityKey);
        }

        public void Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
        }
    }
}
