using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class OrderHistory : Entity
  {
    public int OrderID { get; set; }
    public string PizzaName { get; set; }
    public DateTime TimeStamp;
    public int CustomID { get; set; }
    public int StoreID { get; set; }
    public double PizzaPrice { get; set; }
  }
}