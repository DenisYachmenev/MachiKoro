using System.ComponentModel.DataAnnotations.Schema;

namespace MachiKaro.Service.Entities;

[Table("LayoutItems")]
public class LayoutItem
{
    public int Id {get; set; }
    
    public int LayoutId { get; set; }
    public Layout? Layout { get; set; }

    public int CardId { get; set; }
    public Card? Card { get; set; }

    public int Count { get; set; }
    public bool IsActive { get; set; }
}