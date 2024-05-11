using System.ComponentModel.DataAnnotations.Schema;

namespace MachiKaro.Service.Entities;

[Table("Users", Schema = "machikoro")]
public class User
{
    public int Id {get; set; }
    public required string Name { get; set; }
    public required List<Game> Games { get; set; }
}