using MachiKaro.Service.Entities;
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

    [HttpPost("createLayout/{gameId}/{userId}")]
    public int CreateLayout(int gameId, int userId, [FromBody] LayoutItemDto[] layoutItemDtos)
    {
        return _service.CreateLayout(gameId, userId, layoutItemDtos);
    }

    [HttpPost("addLayoutItem/{layoutId}/{cardId}")]
    public void AddLayoutItem(int layoutId, int cardId)
    {
        _service.AddLayoutItem(layoutId, cardId);
    }

    [HttpPost("activateLayoutItem/{layoutId}/{cardId}")]
    public void ActivateLayoutItem(int layoutId, int cardId)
    {
        _service.ActivateLayoutItem(layoutId, cardId);
    }
}