using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MachiKaro.Service.Entities;

[Table("Games")]
public class Game
{
    public required string Id {get; set; }
    
    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public required User User { get; set; }
    
    public int CardId { get; set; }
    [ForeignKey("CardId")]
    public required Card Card { get; set; }

    public int Count { get; set; }
}