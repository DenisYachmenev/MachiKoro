using MachiKaro.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ServiceContext>();
builder.Services.AddScoped<ServiceContext>();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Run();
