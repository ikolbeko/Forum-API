namespace Forum.Models.Entities
{
    public class TopicMessage : BaseEntity
    {
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public User Author { get; set; }
        public int TopicId { get; set; }
    }
}
