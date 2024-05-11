using MachiKaro.Service.Entities;
using MachiKaro.Service.Services.interfaces;

namespace MachiKaro.Service.Services.Implementations;

public class UserService : IUserService
{
    private readonly ServiceContext _context;

    public UserService(ServiceContext context)
    {
        _context = context;
    }

    public int Add(string name)
    {
        var user = _context.Add(new User(){ Name = name });

        _context.SaveChanges();

        return user.Entity.Id;
    }
}