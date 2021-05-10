using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Topping : Entity
  {
    public string Name { get; set; }
    public ICollection<Pizza> Pizzas { get; set; }
    public int Type { get; set; }
    public override string ToString()
    {
      return $"{Name}";
    }
  }
}