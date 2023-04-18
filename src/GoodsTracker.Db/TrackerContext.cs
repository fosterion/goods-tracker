using GoodsTracker.Db.Configurations;
using GoodsTracker.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace GoodsTracker.Db;

public class TrackerContext : DbContext
{
    public DbSet<History> History { get; set; }
    public DbSet<Product> Products { get; set; }

    public TrackerContext(DbContextOptions<TrackerContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new HistoryConfiguration());
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
    }
}
