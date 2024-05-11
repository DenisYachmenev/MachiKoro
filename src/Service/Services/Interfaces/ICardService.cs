using MachiKaro.Service.Services.Dto;

namespace MachiKaro.Service.Services.interfaces;

public interface ICardService
{
    CardDto[] GetByType(int type);
    CardDto[] GetByNumber(int number);
}