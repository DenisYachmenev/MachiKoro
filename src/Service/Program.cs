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

builder.Services.AddTransient<ICardService, CardService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IGameService, GameService>();
builder.Services.AddTransient<IGameProcessService, GameProcessService>();
builder.Services.AddTransient<ILayoutService, LayoutService>();
builder.Services.AddTransient<IDiceService, DiceService>();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.MapControllers();

app.Run();
