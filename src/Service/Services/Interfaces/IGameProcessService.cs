using MachiKaro.Service.Services.Dto;

namespace MachiKaro.Service.Services.interfaces;

public interface IGameProcessService
{
    StepResultDto Step(int gameId, int userId, int number);
}