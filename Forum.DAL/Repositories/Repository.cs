using Forum.Core.Entities;
using Forum.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Forum.DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DataContext _dbContext;
        public Repository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Edit(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public virtual T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }
    }
}
