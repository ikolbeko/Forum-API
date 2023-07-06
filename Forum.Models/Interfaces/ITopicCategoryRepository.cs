using Forum.Models.Entities;

namespace Forum.Models.Interfaces
{
    public interface ITopicCategoryRepository : IRepository<TopicCategory>
    {
        List<TopicCategory> GetAllTopicCategory();
    }
}
