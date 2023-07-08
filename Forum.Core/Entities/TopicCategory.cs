namespace Forum.Core.Entities
{
    public class TopicCategory : BaseEntity
    {
        public string Name { get; set; }
        public List<Topic> Topics { get; set; }
    }
}
