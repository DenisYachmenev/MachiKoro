using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MachiKaro.Service.Entities;

[Table("Games")]
public class Game
{
    public required string Id {get; set; }
    
    public int OwnerId { get; set; }
    public User? Owner { get; set; }
    
    public List<User> Users { get; set; } = new List<User>();
}