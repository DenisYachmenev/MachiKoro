using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MachiKaro.Service.Entities;

[Table("Games")]
public class Game
{
    public int Id {get; set; }
    
    public int OwnerId { get; set; }
    public User? Owner { get; set; }
    
    public bool IsActive { get; set; }

    public List<User> Users { get; set; } = new List<User>();

    public List<Layout> Layouts { get; set; } = new List<Layout>();
}