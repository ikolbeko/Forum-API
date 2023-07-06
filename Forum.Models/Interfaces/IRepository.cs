using Forum.Models.Entities;
using System.Linq.Expressions;

namespace Forum.Models.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int id);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
    }
}
