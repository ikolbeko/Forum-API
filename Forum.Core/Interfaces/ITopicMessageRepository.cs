using Forum.Core.Entities;

namespace Forum.Core.Interfaces
{
    public interface ITopicMessageRepository : IRepository<TopicMessage>
    {
        List<TopicMessage> GetMessagesByTopicId(int topicId);
    }
}
