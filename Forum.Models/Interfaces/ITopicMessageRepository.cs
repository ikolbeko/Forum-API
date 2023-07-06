using Forum.Models.Entities;

namespace Forum.Models.Interfaces
{
    public interface ITopicMessageRepository : IRepository<TopicMessage>
    {
        List<TopicMessage> GetMessagesByTopicId(int topicId);
    }
}
