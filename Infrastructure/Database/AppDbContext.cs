using Infrastructure.Database.RobotsPermissionEntity;
using Infrastructure.Database.UrlEntity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database;

public class AppDbContext : DbContext
{
    
    public DbSet<Url> Urls { get; set; }
    public DbSet<RobotsPermission> RobotsPermissions { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(RobotPermissionConfiguration).Assembly);
        
    }
}