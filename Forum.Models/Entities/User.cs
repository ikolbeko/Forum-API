using Microsoft.AspNetCore.Identity;

namespace DataModel.Entities;

public class User: IdentityUser
{
    public string Photo { get; set; }
    public string Email { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime LastEntry { get; set; }
}
