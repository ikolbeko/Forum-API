using Forum.Core.Entities;
using Forum.Core.Interfaces;

namespace Forum.DAL.Repositories
{
    public class TopicCategoryRepository : Repository<TopicCategory>, ITopicCategoryRepository
    {
        private readonly DataContext _dbContext;
        public TopicCategoryRepository(DataContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public List<TopicCategory> GetAllTopicCategory()
        {
            return _dbContext.TopicCategories.ToList();
        }
    }
}
