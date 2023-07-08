using Forum.Core.Entities;

namespace Forum.Core.Interfaces
{
    public interface ITopicRepository : IRepository<Topic>
    {
        List<Topic> GetTopicsByCategoryId(TopicCategory category);
    }
}