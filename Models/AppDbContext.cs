using Microsoft.EntityFrameworkCore;
namespace SocialMediaApp.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Posts> Posts { get; set; }
    public DbSet<Reposts> Reposts { get; set; }
}