using System.ComponentModel.DataAnnotations.Schema;

namespace MachiKaro.Service.Entities;

[Table("Numbers")]
public class Number
{
    public int Id { get; set;}
    public int Value { get; set;}

    public required List<Card> Cards{ get; set; }
}