using MachiKaro.Service.Entities;
using Microsoft.EntityFrameworkCore;

namespace MachiKaro.Service;

public class ServiceContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Number> Numbers { get; set; }
    public DbSet<Card> Cards { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<Layout> Layouts { get; set; }
    public DbSet<LayoutItem> LayoutItems { get; set; }

    public ServiceContext(DbContextOptions<ServiceContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=MachiKoro.db");

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Game>()
            .HasOne(game => game.Owner)
            .WithMany(user => user.MyGames);

        modelBuilder.Entity<Layout>()
            .HasOne(layout => layout.Game)
            .WithMany(game => game.Layouts);

        modelBuilder.Entity<Layout>()
            .HasOne(layout => layout.User)
            .WithMany(user => user.Layouts);

        modelBuilder.Entity<LayoutItem>()
            .HasOne(item => item.Layout)
            .WithMany(layout => layout.LayoutItems);

        base.OnModelCreating(modelBuilder);
    }
}
