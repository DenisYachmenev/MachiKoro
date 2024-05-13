using MachiKaro.Service.Entities;
using MachiKaro.Service.Services.Dto;
using MachiKaro.Service.Services.interfaces;

namespace MachiKaro.Service.Services.Implementations;

public class LayoutService : ILayoutService
{
    private readonly ServiceContext _context;

    public LayoutService(ServiceContext context)
    {
        _context = context;
    }

    public int CreateLayout(int gameId, int userId, LayoutItemDto[] layoutItemDtos)
    {
        var layout = _context.Layouts.Add(new Layout()
        {
            GameId = gameId,
            UserId = userId,
        });
        // TODO: А как сделать чтобы один раз только вызывать
        _context.SaveChanges();

        _context.LayoutItems.AddRange(layoutItemDtos.Select(dto => new LayoutItem()
        {
            LayoutId = layout.Entity.Id,
            CardId = dto.CardId,
            Count = 1,
            IsActive = dto.IsActive,
        }).ToArray());

        _context.SaveChanges();

        return layout.Entity.Id;
    }

    public void AddLayoutItem(int layoutId, int cardId)
    {
        var item = _context.LayoutItems.FirstOrDefault(i => i.LayoutId == layoutId && i.CardId == cardId);

        if (item == null)
        {
            _context.LayoutItems.Add(new LayoutItem()
            {
                LayoutId = layoutId,
                CardId = cardId,
                Count = 1,
                IsActive = true,
            });
        }
        else 
        {
            item.Count++;
        }

        _context.SaveChanges();
    }

    public void ActivateLayoutItem(int layoutId, int cardId)
    {
        var item = _context.LayoutItems.First(i => i.LayoutId == layoutId && i.CardId == cardId);
        
        item.IsActive = true;

        _context.SaveChanges();
    }
}