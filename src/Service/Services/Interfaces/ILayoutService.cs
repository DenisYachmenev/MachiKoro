using MachiKaro.Service.Services.Dto;

namespace MachiKaro.Service.Services.interfaces;

public interface ILayoutService
{
    int CreateLayout(int gameId, int userId, LayoutItemDto[] layoutItemDtos);
    void AddLayoutItem(int layoutId, int cardId);
    void ActivateLayoutItem(int layoutId, int cardId);
}