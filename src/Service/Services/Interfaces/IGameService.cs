namespace MachiKaro.Service.Services.interfaces;

public interface IGameService
{
    string Create(int userId);
    void AddUserToGame(string gameId, int userId);
}