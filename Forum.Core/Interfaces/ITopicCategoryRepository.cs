using Forum.Core.Entities;

namespace Forum.Core.Interfaces
{
    public interface ITopicCategoryRepository : IRepository<TopicCategory>
    {
        List<TopicCategory> GetAllTopicCategory();
    }
}
