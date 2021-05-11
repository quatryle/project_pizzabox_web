using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage
{
  public class PizzaBoxContext : DbContext
  {
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Store> Stores { get; set; }
    public DbSet<Crust> Crusts { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Pizza> Pizzas { get; set; }
    public DbSet<Size> Sizes { get; set; }
    public DbSet<Topping> Toppings { get; set; }
    public DbSet<PresetPizza> PresetPizzas { get; set; }
    public DbSet<OrderHistory> History { get; set; }

    public PizzaBoxContext(DbContextOptions options) : base(options)
    {
      //_config = Configuration.Build();
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Crust>().HasKey(e => e.EntityId);
      modelBuilder.Entity<Customer>().HasKey(e => e.EntityId);
      modelBuilder.Entity<Order>().HasKey(e => e.EntityId);
      modelBuilder.Entity<Pizza>().HasKey(e => e.EntityId);
      modelBuilder.Entity<Size>().HasKey(e => e.EntityId);
      modelBuilder.Entity<Store>().HasKey(e => e.EntityId);
      modelBuilder.Entity<Topping>().HasKey(e => e.EntityId);
      modelBuilder.Entity<PresetPizza>().HasKey(e => e.EntityId);
      modelBuilder.Entity<OrderHistory>().HasKey(e => e.EntityId);

      modelBuilder.Entity<Customer>().HasMany(c => c.Orders).WithOne(o => o.Customers);
      modelBuilder.Entity<Store>().HasMany(s => s.Orders).WithOne(o => o.Stores);
      //modelBuilder.Entity<OrderHistory>().HasMany(s => s.Orders).WithOne(o => o.Stores);
      //modelBuilder.Entity<OrderHistory>().HasOne(s => s.Stores).WithOne(o => o.Stores);
      //modelBuilder.Entity<OrderHistory>().HasOne(s => s.Customer).WithOne(o => o.Stores);

      OnModelSeeding(modelBuilder);
    }
    private static void OnModelSeeding(ModelBuilder modelBuilder)
    {
      //_config = Configuration;
      modelBuilder.Entity<Customer>().HasData(new[]
      {
      new Customer() { EntityId = 1, Name = "John Connor"},
      new Customer() { EntityId = 2, Name = "Thaddeus Good Ignatius Friday"}
      });
      modelBuilder.Entity<Store>().HasData(new[]
      {
      new Store() { EntityId = 1, Name = "Times Square Store"},
      new Store() { EntityId = 2, Name = "Liberty Park Store"},
      new Store() { EntityId = 3, Name = "Harvard Square Store"}
      });
      modelBuilder.Entity<PresetPizza>().HasData(new[]
      {
      new PresetPizza() { EntityId = 1, Name = "Custom Pizza"},
      new PresetPizza() { EntityId = 2, Name = "Margherita Pizza", Crust = "Plain", Top1 = "Tomato Sauce", Top2 = "Mozzarella Cheese"},
      new PresetPizza() { EntityId = 3, Name = "Pepperoni Pizza", Crust = "Plain", Top1 = "Tomato Sauce", Top2 = "Mozzarella Cheese", Top3 = "Pepperoni"},
      new PresetPizza() { EntityId = 4, Name = "Chicken Alfredo Pizza", Crust = "Plain", Top1 = "Alfredo Sauce", Top2 = "Mozzarella Cheese", Top3 = "Sausage"},
      new PresetPizza() { EntityId = 5, Name = "Deep Dish Pizza", Crust = "Deep Dish", Top1 = "Tomato Sauce", Top2 = "Mozzarella Cheese"},
      new PresetPizza() { EntityId = 6, Name = "Thin Crust Pizza", Crust = "Thin Crust", Top1 = "Tomato Sauce", Top2 = "Mozzarella Cheese"},
      new PresetPizza() { EntityId = 7, Name = "Meat Pizza", Crust = "Plain", Top1 = "Tomato Sauce", Top2 = "Mozzarella Cheese", Top3 = "Sausage", Top4 = "Bacon", Top5 = "Chicken", Top6 = "Pepperoni"},
      new PresetPizza() { EntityId = 8, Name = "Veggie Pizza", Crust = "Plain", Top1 = "Tomato Sauce", Top2 = "Mozzarella Cheese", Top3 = "Sliced Tomato", Top4 = "Mushrooms", Top5 = "Onions", Top6 = "Olives", Top7 = "Green Peppers"},
      new PresetPizza() { EntityId = 9, Name = "Four Cheese Pizza", Crust = "Plain", Top1 = "Tomato Sauce", Top2 = "Mozzarella Cheese", Top3 = "Cheddar Cheese", Top4 = "Provalone Cheese", Top5 = "Parmesan Cheese"},
      });
      modelBuilder.Entity<Crust>().HasData(new[]
      {
      new Crust() { EntityId = 1, Name = "Plain"},
      new Crust() { EntityId = 2, Name = "Thin Crust"},
      new Crust() { EntityId = 3, Name = "Deep Dish"},
      new Crust() { EntityId = 4, Name = "Stuffed Crust"}
      });
      modelBuilder.Entity<Size>().HasData(new[]
      {
      new Size() { EntityId = 1, Name = "Small"},
      new Size() { EntityId = 2, Name = "Medium"},
      new Size() { EntityId = 3, Name = "Large"}
      });
      modelBuilder.Entity<Topping>().HasData(new[]
      {
      new Topping() { EntityId = 1, Name = "Tomato Sauce", Type = 1},
      new Topping() { EntityId = 2, Name = "Alfredo Sauce", Type = 1},
      new Topping() { EntityId = 3, Name = "Garlic Sauce", Type = 1},
      new Topping() { EntityId = 4, Name = "Mozzarella Cheese", Type = 2},
      new Topping() { EntityId = 5, Name = "Cheddar Cheese", Type = 2},
      new Topping() { EntityId = 6, Name = "Provalone Cheese", Type = 2},
      new Topping() { EntityId = 7, Name = "Parmesan Cheese", Type = 2},
      new Topping() { EntityId = 8, Name = "Pepperoni", Type = 3},
      new Topping() { EntityId = 9, Name = "Sausage", Type = 3},
      new Topping() { EntityId = 10, Name = "Anchovy", Type = 3},
      new Topping() { EntityId = 11, Name = "Bacon", Type = 3},
      new Topping() { EntityId = 12, Name = "Chicken", Type = 3},
      new Topping() { EntityId = 13, Name = "Ham", Type = 3},
      new Topping() { EntityId = 14, Name = "Sliced Tomato", Type = 3},
      new Topping() { EntityId = 15, Name = "Onions", Type = 3},
      new Topping() { EntityId = 16, Name = "Green Peppers", Type = 3},
      new Topping() { EntityId = 17, Name = "Olives", Type = 3},
      new Topping() { EntityId = 18, Name = "Mushrooms", Type = 3}
      });
    }

  }
}