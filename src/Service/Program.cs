using MachiKaro.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ServiceContext>();
builder.Services.AddScoped<ServiceContext>();

var app = builder.Build();

using(var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ServiceContext>();
    dbContext.Database.EnsureCreated();
}

//app.MapGet("/", () => "Hello World!");

app.Run();
