using Microsoft.EntityFrameworkCore;

namespace PizzaBox.Storage
{
  public class PizzaBoxContext : DbContext
  {
    public DbSet<Crust> Crust { get; set; }
    public DbSet<Size> Size { get; set; }
    public DbSet<Topping> Toppings { get; set; }
    public PizzaBoxContext(DbContextOptions options) : base(options)
    {
      _config = Configuration.Build();
    }
    protected override void OnModelCreating(ModelBuilding builder)
    {
      builder.Entity<Crust>(HasKey)(e => e.EntityId);
      builder.Entity<Order>(HasKey)(e => e.EntityId);
      builder.Entity<PizzaBox>().HasKey(e => EntityId);
      builder.Entity<Size>(HasKey)(e => e.EntityId);
      builder.Entity<Topping>(HasKey)(e => e.EntityId);
    }
    protected override void OnConfiguring(DBContextOptionBuilder builder)
    {
      _config = Configuration;

      builder.Entity<Crust>().HasData(new[]
      {
      new Crust() { EntityId = 1, Name = "Plain"},
      new Crust() { EntityId = 2, Name = "Thin Crust"},
      new Crust() { EntityId = 3, Name = "Deep Dish"},
      new Crust() { EntityId = 4, Name = "Stuffed Crust"}
      });

      builder.Entity<Size>().HasData(new[]
      {
      new Size() { EntityId = 1, Name = "small"},
      new Size() { EntityId = 2, Name = "medium"},
      new Size() { EntityId = 3, Name = "large"}
      });
      builder.Entity<Topping>().HasData(new[]
      {
      new Topping() { EntityId = 1, Name = "pepperoni"},
      new Topping() { EntityId = 2, Name = "sausage"},
      new Topping() { EntityId = 3, Name = "ham"},
      new Topping() { EntityId = 4, Name = "bacon"},
      new Topping() { EntityId = 5, Name = "anchovy"},
      });
    }

  }
}