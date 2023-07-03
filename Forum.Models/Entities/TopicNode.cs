namespace Forum.Models.Entities;

public class TopicNode: BaseEntity
{
    public int ParentId { get; set; }
    public string NodeName { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Order { get; set; }
    public DateTime CreateOn { get; set; }
}
