using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RangoAgil.API.Entities;

public class Ingredient
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public required string Name { get; set; }

    public ICollection<Dishe> Dishes { get; set; } = new List<Dishe>();

    public Ingredient()
    {

    }

    [SetsRequiredMembers]
    public Ingredient(int id, string name)
    {
        Name = name;
        Id = id;
    }
}
