using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace SocialMediaApp.Models;

public class Reposts
{
    [Key]
    public int RepostId { get; set; }
    public required int PostId { get; set; }
    public required Posts Post { get; set; }
    public required int UserId { get; set; }
    public required User User { get; set; }
}