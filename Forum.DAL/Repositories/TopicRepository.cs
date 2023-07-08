using Forum.Core.Entities;
using Forum.Core.Interfaces;

namespace Forum.DAL.Repositories
{
    public class TopicRepository : Repository<Topic>, ITopicRepository
    {
        private readonly DataContext _dbContext;
        public TopicRepository(DataContext dbContext)
            : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Topic> GetTopicsByCategoryId(TopicCategory topicCategory)
        {
            return _dbContext.Topics.Where(category => category.Category == topicCategory).ToList();
        }
    }
}
