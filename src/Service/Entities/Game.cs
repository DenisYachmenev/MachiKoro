using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MachiKaro.Service.Entities;

[Table("Games")]
public class Game
{
    public string Id {get; set; }
    
    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }
    
    public int CardId { get; set; }
    [ForeignKey("CardId")]
    public Card Card { get; set; }

    public int Count { get; set; }
}