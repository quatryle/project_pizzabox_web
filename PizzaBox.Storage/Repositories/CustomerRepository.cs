using System;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class CustomerRepository : IRepository<Customer>
  {
    private readonly PizzaBoxContext _context;

    public CustomerRepository(PizzaBoxContext context)
    {
      _context = context;
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(Customer entry)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Customer> Select(Func<Customer, bool> filter)
    {
      throw new System.NotImplementedException();
    }

    public Customer Update()
    {
      throw new System.NotImplementedException();
    }
  }
}