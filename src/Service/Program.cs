using MachiKaro.Service;
using MachiKaro.Service.Services.Implementations;
using MachiKaro.Service.Services.interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<ServiceContext>( options =>
{
    options.UseSqlite( builder.Configuration.GetConnectionString("DataSource=MachiKoro.db") );
} );
//builder.Services.AddScoped<ServiceContext>();

builder.Services.AddTransient<ICardsService, CardsService>();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.MapControllers();

app.Run();
