using MachiKaro.Service.Services.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MachiKaro.Service.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GamesController : ControllerBase
{
    private readonly IGameService _service;

    public GamesController(IGameService service)
    {
        _service = service;
    }

    [HttpPost]
    public string Create(int userId)
    {
        return _service.Create(userId);
    } 

    [HttpPost("addUserToGame/{gameId}/{userId}")]
    public void AddUserToGame(string gameId, int userId)
    {
        _service.AddUserToGame(gameId, userId);
    } 
}