using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Prison.Data;
using Prison.Models;

namespace Stoelendans.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly PrisonDbContext _dbContext;
        private readonly DbSet<T> _modelDbSets;

        public Repository(PrisonDbContext dbContext)
        {
            _dbContext = dbContext;
            _modelDbSets = _dbContext.Set<T>();
        }
        
        public void Add(T entity)
        {
            _modelDbSets.Add(entity);
        }

        public void Delete(T entity)
        {
            _modelDbSets.Remove(entity);
        }

        public void Update(T entity)
        {
            _modelDbSets.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<T> GetAll()
        {
            return _modelDbSets;
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate)
        {
            return await _modelDbSets.Where(predicate).ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await _modelDbSets.Where(predicate).FirstOrDefaultAsync();
        }

        public IQueryable<T> Query(Expression<Func<T, bool>> predicate)
        {
            return _modelDbSets.Where(predicate);
        }

        public async Task<int> SaveAsync()
        {
            int i = await _dbContext.SaveChangesAsync();
            return i;
        }
    }
}
