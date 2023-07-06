using Forum.Models.Entities;
using Forum.Models.Interfaces;

namespace Forum.Repository.Repositories
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
