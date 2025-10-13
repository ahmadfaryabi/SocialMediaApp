using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SocialMediaApp.Models;

namespace SocialMediaApp.Controllers;
public class HomeController : Controller
{
    public async Task<ActionResult> Index()
    {

        var users = new List<User>();
        var user1 = new User
        {
            UserId = 1,
            Username = "Ahmadfaryabi",
            Email = "ahmad@lol.com",
            PasswordHash = "hashed_password",
            ProfilePictureUrl = "https://example.com/profile1.jpg",
            Posts = new List<Posts>(),
            Reposts = new List<Reposts>(),
            followers = new List<User>(),
            following = new List<User>()
        };
        users.Add(user1);

        var posts = new List<Posts>();
        var post1 = new Posts
        {
            Id = 1,
            images = new List<string> { "https://example.com/image1.jpg", "https://example.com/image2.jpg" },
            location = "New York, NY",
            description = "Enjoying the sunny weather!",
            hashtags = new List<string> { "#sunny", "#vacation" },
            UserId = 1,
            User = user1
        };
        
        posts.Add(post1);

        return View(posts);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}