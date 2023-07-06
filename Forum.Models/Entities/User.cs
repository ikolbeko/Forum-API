using Microsoft.AspNetCore.Identity;

namespace Forum.Models.Entities;

public class User: IdentityUser
{
    public string Avatar { get; set; }
    public string Email { get; set; }
    public string Url { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime LastEntry { get; set; }
}
