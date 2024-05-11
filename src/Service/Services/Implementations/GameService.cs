using MachiKaro.Service.Entities;
using MachiKaro.Service.Services.interfaces;
using Microsoft.EntityFrameworkCore;

namespace MachiKaro.Service.Services.Implementations;

public class GameService : IGameService
{
    private readonly ServiceContext _context;

    public GameService(ServiceContext context)
    {
        _context = context;
    }

    public string Create(int userId)
    {
        var user = _context.Users.First(u => u.Id == userId);

        var game = _context.Games
            .Add(new Game() { Id = Guid.NewGuid().ToString(), OwnerId = userId, Users = new List<User> { user } });

        _context.SaveChanges();

        return game.Entity.Id;
    }

    public void AddUserToGame(string gameId, int userId)
    {
        var user = _context.Users.First(u => u.Id == userId);

        var game = _context.Games.Include(g => g.Users).First(g => g.Id == gameId);

        game.Users.Add(user);

        _context.SaveChanges();
    }
}