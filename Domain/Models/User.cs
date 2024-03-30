using Microsoft.AspNetCore.Identity;
namespace Domain.Models.User;


public class User : IdentityUser
{
    public int Id { get; set; }
    public string UserName { get; set; }
}