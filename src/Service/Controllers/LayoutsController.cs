using MachiKaro.Service.Services.Dto;
using MachiKaro.Service.Services.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MachiKaro.Service.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LayoutsController : ControllerBase
{
    private readonly ILayoutService _service;

    public LayoutsController(ILayoutService service)
    {
        _service = service;
    }
}