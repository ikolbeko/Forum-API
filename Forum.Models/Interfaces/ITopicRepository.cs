using Forum.Models.Entities;
using System.Linq.Expressions;

namespace Forum.Models.Interfaces;

public interface ITopicRepository : IRepository<Topic>
{
    Page<Topic> PageList(int pagesize, int pageindex);
    Page<Topic> PageList(Expression<Func<Topic, bool>> predicate, int pagesize, int pageindex);
}
