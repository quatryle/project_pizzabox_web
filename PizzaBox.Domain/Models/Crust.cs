namespace PizzaBox.Domain.Models
{
  public class Crust : Entity
  {
    public string Name { get; set; }
    public ICollection<Pizza> Pizzas { get; set; }
    public override string ToString()
    {
      return $"{Name}";
    }
  }
}