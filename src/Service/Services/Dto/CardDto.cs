namespace MachiKaro.Service.Services.Dto;

public class CardDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int Price { get; set; }
    public required string Action { get; set; }
    public int Type { get; set; }
    public required int[] Numbers { get; set; }
}