using MachiKaro.Service.Services.Dto;
using MachiKaro.Service.Services.interfaces;
using Microsoft.EntityFrameworkCore;

namespace MachiKaro.Service.Services.Implementations;

public class LayoutService : ILayoutService
{
    private readonly ServiceContext _context;

    public LayoutService(ServiceContext context)
    {
        _context = context;
    }
}