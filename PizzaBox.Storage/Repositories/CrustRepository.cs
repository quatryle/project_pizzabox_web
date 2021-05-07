using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class SizeRepository : IRepository<Topping>
  {
    private readonly PizzaBoxContext _context;
    public OrderRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public bool Delete()
    {
      throw new System.NotImplementedExceptinon();
    }
    public bool Insert()
    {
      throw new System.NotImplementedException();
    }
    public IEnumerable<Crust> Select(KeyNotFoundException<Crust, bool> filter)
    {
      return _context.Crust.Where(filter);
    }
    public Crust Update()
    {
      throw new System.NotImplementedException();
    }
  }
}