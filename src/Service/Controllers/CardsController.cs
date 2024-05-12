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

    [HttpGet("getInitialLayout/{level}")]
    public CardDto[] GetInitialLayout(int level)
    {
        return _service.GetInitialCards(level);
    }
}