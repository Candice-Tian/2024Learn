namespace NetCoreLearn.Models;

public class Pizza
{
    public int Id { get; set; }

    [Required]
    [MaxLength(10)]
    public string? Name { get; set; }

    public Sauce? Sauce { get; set; }

    public ICollection<Topping>? Toppings { get; set; }
}