namespace NetCoreLearn.Data;
public class PizzaContext : DbContext
{
    public PizzaContext(DbContextOptions<PizzaContext> options)
        : base(options)
    {
    }

    //Refer to the Pizza table
    public DbSet<Pizza> Pizzas => Set<Pizza>();
    public DbSet<Topping> Toppings => Set<Topping>();
    public DbSet<Sauce> Sauces => Set<Sauce>();
}
