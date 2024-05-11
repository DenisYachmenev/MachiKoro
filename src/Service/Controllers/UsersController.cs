using MachiKaro.Service.Services.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MachiKaro.Service.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserService _service;

    public UsersController(IUserService service)
    {
        _service = service;
    }

    [HttpPost]
    public int Add(string name)
    {
        return _service.Add(name);
    } 
}