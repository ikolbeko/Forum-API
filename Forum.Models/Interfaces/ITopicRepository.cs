using Forum.Models.Entities;

namespace Forum.Models.Interfaces
{
    public interface ITopicRepository : IRepository<Topic>
    {
        List<Topic> GetTopicsByCategoryId(int categoryId);
    }
}