using System;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class PresetPizzaRepository : IRepository<PresetPizza>
  {
    private readonly PizzaBoxContext _context;

    public PresetPizzaRepository(PizzaBoxContext context)
    {
      _context = context;
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(PresetPizza entry)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<PresetPizza> Select(Func<PresetPizza, bool> filter)
    {
      throw new System.NotImplementedException();
    }

    public PresetPizza Update()
    {
      throw new System.NotImplementedException();
    }
  }
}