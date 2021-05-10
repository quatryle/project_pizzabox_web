using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Store : Entity
  {
    public string Name { get; set; }
    public ICollection<Order> Orders { get; set; }
    public override string ToString()
    {
      return $"{Name}";
    }
  }
}