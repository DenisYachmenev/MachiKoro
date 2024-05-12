namespace MachiKaro.Service.Services.interfaces;

public interface IGameService
{
    int Create(int userId);
    void AddUserToGame(int gameId, int userId);
    void Start(int gameId);
}