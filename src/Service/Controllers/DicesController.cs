using MachiKaro.Service.Services.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MachiKaro.Service.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DicesController : ControllerBase
{
    private readonly IDiceService _service;

    public DicesController(IDiceService service)
    {
        _service = service;
    }

    [HttpGet]
    public int GetRollResult()
    {
        return _service.GetRollResult();
    }
}