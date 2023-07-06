using Forum.Models.Entities;
using Forum.Models.Interfaces;

namespace Forum.Repository.Repositories
{
    public class TopicRepository : Repository<Topic>, ITopicRepository
    {
        private readonly DataContext _dbContext;
        public TopicRepository(DataContext dbContext)
            : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Topic> GetTopicsByCategoryId(int categoryId)
        {
            return _dbContext.Topics.Where(category => category.CategoryId == categoryId).ToList();
        }
    }
}
