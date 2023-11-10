using System.ComponentModel.DataAnnotations;

namespace GameStore.Client.Models;

public class Game
{
    public int ID { get; set; }
    [Required]
    [StringLength(50, MinimumLength = 3)]
    public required string Name { get; set; }
    [Required]
    [StringLength(20, MinimumLength = 3)]
    public required string Genre { get; set; }
    [Range(1.00, 99.99)]
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }
}