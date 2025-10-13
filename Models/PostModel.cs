namespace SocialMediaApp.Models;

// model for posts, some of theme are required like images, up to 10 maximim

public class Posts
{
    // id primary key
    public int Id { get; set; }
    // array of images
    public required List<string> images { get; set; }
    // optional location, description and hashtags
    public String? location { get; set; }
    public String? description { get; set; }
    public List<string>? hashtags { get; set; }
    public required int UserId { get; set; }
    public required User User { get; set; }
}