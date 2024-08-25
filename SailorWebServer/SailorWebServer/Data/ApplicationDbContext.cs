using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SailorWebServer.Models.Entities;
using SailorWebServer.Models.Entities.Geo;

namespace SailorWebServer.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<SubscribeModel> Subscribers { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<AreaModel> Areas { get; set; }
    
    public DbSet<CityModel> Cities { get; set; }
    
    public DbSet<CityTypeModel> CityTypes { get; set; }
    
    public DbSet<StreetModel> Streets { get; set; }
    
    public DbSet<Friend> Friends { get; set; }
    
    public DbSet<TagModel> Tags { get; set; }
    
    public DbSet<CategoryModel> Categories { get; set; }
    
    public DbSet<PostModel> Posts { get; set; }
}