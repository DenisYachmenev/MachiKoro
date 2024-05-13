using Microsoft.AspNetCore.Mvc;
using MachiKaro.Service.Services.interfaces;
using MachiKaro.Service.Services.Dto;

namespace MachiKaro.Service.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CardsController : ControllerBase
{
    private readonly ICardService _service;

    public CardsController(ICardService service)
    {
        _service = service;
    }

    [HttpGet("getInitialCards/{level}")]
    public CardDto[] GetInitialCards(int level)
    {
        return _service.GetInitialCards(level);
    }

    [HttpGet("getReserveCards/{level}")]
    public CardDto[] GetReserveCards(int level)
    {
        return _service.GetReserveCards(level);
    }
}