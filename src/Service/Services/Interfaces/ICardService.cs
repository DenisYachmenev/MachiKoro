using MachiKaro.Service.Services.Dto;

namespace MachiKaro.Service.Services.interfaces;

public interface ICardService
{
    CardDto[] GetInitialCards(int level);
}