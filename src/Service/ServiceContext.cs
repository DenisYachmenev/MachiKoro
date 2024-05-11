using MachiKaro.Service.Entities;
using Microsoft.EntityFrameworkCore;

namespace MachiKaro.Service;

public class ServiceContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Number> Numbers { get; set; }
    public DbSet<Card> Cards { get; set; }
    public DbSet<Game> Games { get; set; }

    public ServiceContext(DbContextOptions<ServiceContext> options) : base(options)
    {
    }
}
