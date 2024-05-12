using System.ComponentModel.DataAnnotations.Schema;

namespace MachiKaro.Service.Entities;

[Table("Layouts")]
public class Layout
{
    public int Id {get; set; }
    
    public int GameId { get; set; }
    public Game? Game { get; set; }

    public int UserId { get; set; }
    public User? User { get; set; }

    public List<LayoutItem> LayoutItems { get; set; } = new List<LayoutItem>();
}