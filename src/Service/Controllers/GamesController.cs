using MachiKaro.Service.Services.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MachiKaro.Service.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GamesController : ControllerBase
{
    private readonly IGameService _service;
    private readonly IGameProcessService _processService;

    public GamesController(
        IGameService service, 
        IGameProcessService processService)
    {
        _service = service;
        _processService = processService;
    }

    [HttpPost]
    public int Create(int userId)
    {
        return _service.Create(userId);
    } 

    [HttpPost("addUserToGame/{gameId}/{userId}")]
    public void AddUserToGame(int gameId, int userId)
    {
        _service.AddUserToGame(gameId, userId);
    } 

    [HttpPost("start/{gameId}")]
    public void Start(int gameId)
    {
        _service.Start(gameId);
    }

    [HttpPost("step/{gameId}/{userId}/{number}")]
    public void Step(int gameId, int userId, int number)
    {
        _processService.Step(gameId, userId, number);
    }
}