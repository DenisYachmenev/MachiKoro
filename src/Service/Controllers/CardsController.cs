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

    [HttpGet("getByType/{type}")]
    public CardDto[] GetByType(int type)
    {
        return _service.GetByType(type);
    }

    [HttpGet("getByNumber/{number}")]
    public CardDto[] GetByNumber(int number)
    {
        return _service.GetByNumber(number);
    }
}