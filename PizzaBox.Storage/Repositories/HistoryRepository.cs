using System;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class HistoryRepository : IRepository<OrderHistory>
  {
    private readonly PizzaBoxContext _context;

    public HistoryRepository(PizzaBoxContext context)
    {
      _context = context;
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(OrderHistory entry)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<OrderHistory> Select(Func<OrderHistory, bool> filter)
    {
      throw new System.NotImplementedException();
    }

    public OrderHistory Update()
    {
      throw new System.NotImplementedException();
    }
  }
}