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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=MachiKoro.db");

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Card>().HasData(
        //     new Card()
        //     {
        //         Id = 1,
        //         Name = "Вокзал",
        //         Price = 4,
        //         Action = "Можно кидать 2 кубика",
        //         Type = 1,
        //         MaxCount = 5,
        //         Level = 1,
        //     },
        //     new Card()
        //     {
        //         Id = 2,
        //         Name = "Торговый центр",
        //         Price = 10,
        //         Action = "Что-то",
        //         Type = 1,
        //         MaxCount = 5,
        //         Level = 1,
        //     },
            // new Card()
            // {
            //     Id = 1,
            //     Name = "Пшеничное поле",
            //     Price = 1,
            //     Action = "Что-то",
            //     Type = 2,
            //     MaxCount = 10,
            //     Level = 1,
            // }
        //     new Card()
        //     {
        //         Id = 4,
        //         Name = "Пекарня",
        //         Numbers = new List<Number>(){ number1, number2 },
        //         Price = 1,
        //         Action = "Что-то",
        //         Type = 3,
        //         MaxCount = 6,
        //         Level = 1,
        //     }
        //);

        base.OnModelCreating(modelBuilder);
    }
}
