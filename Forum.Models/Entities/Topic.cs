namespace Forum.Models.Entities
{
    public class Topic : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public User Author { get; set; }
        public int ReplyCount { get; set; }
        public int CategoryId { get; set; }
        public List<TopicMessage> Messages { get; set; }
    }
}
