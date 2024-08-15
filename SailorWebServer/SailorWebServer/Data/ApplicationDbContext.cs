using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SailorWebServer.Models.Entities;

namespace SailorWebServer.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<SubscribeModel> Subscribers { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<Friend> Friends { get; set; }
    
    public DbSet<TagModel> Tags { get; set; }
    
    public DbSet<CategoryModel> Categories { get; set; }
    
    public DbSet<PostModel> Posts { get; set; }
}