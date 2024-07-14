using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RangoAgil.API.Entities;

public class Dishe
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public required string Name { get; set; }

    public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();


    public Dishe()
    {

    }

    [SetsRequiredMembers]
    public Dishe(int id, string name)
    {
        Name = name;
        Id = id;
    }
}
