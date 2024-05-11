using System.ComponentModel.DataAnnotations.Schema;

namespace MachiKaro.Service.Entities;

[Table("Cards", Schema = "machikoro")]
public class Card
{
    public int Id {get; set; }
    public required string Name { get; set; }
    public List<Number> Numbers { get; set; } = new List<Number>();
    public int Price { get; set; }
    public required string Action { get; set; }
    public int Type { get; set; }
    public int MaxCount { get; set; }
    public int Level { get; set; }
}