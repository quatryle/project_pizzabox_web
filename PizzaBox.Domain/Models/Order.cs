using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Order : Entity
  {
    public Customer Customers { get; set; }
    public Store Stores { get; set; }
    public DateTime TimeStamp;
    public List<Pizza> Pizzas { get; set; }
    public double price()
    {
      double total = 0;
      TimeStamp = DateTime.Now;
      return total;
    }
  }
}