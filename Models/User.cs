namespace SocialMediaApp.Models;
using System.ComponentModel.DataAnnotations;


public class User
{
    [Key]
    public int UserId { get; set; }
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
    public string? ProfilePictureUrl { get; set; }
    public List<Posts> Posts { get; set; } = new List<Posts>();
    public List<Reposts> Reposts { get; set; } = new List<Reposts>();
    public List<User> followers { get; set; } = new List<User>();
    public List<User> following { get; set; } = new List<User>();
}

// You can add more properties as needed, such as Bio, Followers, Following, etc.