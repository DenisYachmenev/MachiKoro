using MachiKaro.Service.Services.Dto;
using MachiKaro.Service.Services.interfaces;
using Microsoft.EntityFrameworkCore;

namespace MachiKaro.Service.Services.Implementations;

public class CardService : ICardService
{
    private readonly ServiceContext _context;

    public CardService(ServiceContext context)
    {
        _context = context;
    }

    public CardDto[] GetByType(int type)
    {
        return _context.Cards
            .Where(c => c.Type == type)
            .Select(c => new CardDto() { Id = c.Id, Name = c.Name, Action = c.Action })
            .ToArray();
    }

    public CardDto[] GetByNumber(int number)
    {
        var item = _context.Numbers
            .Include(n => n.Cards)
            .FirstOrDefault(n => n.Value == number);

        return item == null 
            ? Array.Empty<CardDto>()
            : item.Cards.Select(c => new CardDto (){ Id = c.Id, Name = c.Name, Action = c.Action }).ToArray();
    }
}