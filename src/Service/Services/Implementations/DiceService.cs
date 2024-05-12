using MachiKaro.Service.Entities;
using MachiKaro.Service.Services.interfaces;

namespace MachiKaro.Service.Services.Implementations;

public class DiceService : IDiceService
{
    public int GetRollResult()
    {
        var random = new Random();
        return random.Next(1, 7);
    }
}