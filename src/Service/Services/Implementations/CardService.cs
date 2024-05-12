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

    public CardDto[] GetInitialCards(int level)
    {
        var cards = _context.Cards
            .Include(c => c.Numbers)
            .Where(c => c.IsInitial == true && c.Level == level)
            .ToArray();
        
        return cards.Select(card => new CardDto ()
        {
            Id = card.Id,
            Name = card.Name,
            Price = card.Price,
            Action = card.Action,
            Type = card.Type,
            Numbers = card.Numbers.Select(n => n.Value).ToArray(),
        }).ToArray();
    }
}