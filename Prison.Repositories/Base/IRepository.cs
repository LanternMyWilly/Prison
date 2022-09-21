using System.Linq.Expressions;
using Prison.Models;

namespace Stoelendans.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate);
        IQueryable<T> Query(Expression<Func<T,bool>> predicate);
        IQueryable<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        Task<int> SaveAsync();

    }
}
