using Forum.Models.Entities;
using Forum.Models.Interfaces;

namespace Forum.Repository.Repositories
{
    public class TopicMessageRepository : Repository<TopicMessage>, ITopicMessageRepository
    {
        private readonly DataContext _dbContext;
        public TopicMessageRepository(DataContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public List<TopicMessage> GetMessagesByTopicId(int topicId)
        {
            return _dbContext.TopicMessages.Where(reply => reply.Id == topicId).ToList();
        }
    }
}
