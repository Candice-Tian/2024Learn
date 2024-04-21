namespace NetCoreLearn.Models;

public class Sauce
{
    public int Id { get; set; }

    [Required]
    [MaxLength(10)]
    public string? Name { get; set; }
}