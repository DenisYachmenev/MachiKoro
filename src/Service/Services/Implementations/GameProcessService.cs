using MachiKaro.Service.Services.Dto;
using MachiKaro.Service.Services.interfaces;
using Microsoft.EntityFrameworkCore;

namespace MachiKaro.Service.Services.Implementations;

public class GameProcessService : IGameProcessService
{
    //private readonly ServiceContext _context;

    public GameProcessService(ServiceContext context)
    {
        //_context = context;
    }

    public StepResultDto Step(int gameId, int userId, int number)
    {
        throw new NotImplementedException();
    }
}