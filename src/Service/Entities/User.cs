using System.ComponentModel.DataAnnotations.Schema;

namespace MachiKaro.Service.Entities;

[Table("Users")]
public class User
{
    public int Id {get; set; }
    public required string Name { get; set; }
    public List<Game> MyGames { get; set; } = new List<Game>();
    public List<Game> Games { get; set; } = new List<Game>();
    public List<Layout> Layouts { get; set; } = new List<Layout>();
}