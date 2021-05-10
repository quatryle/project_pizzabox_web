using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storage;
using PizzaBox.Storage.Repositories;

namespace PizzaBox.Client.Models
{
  public class LocationViewModel
  {
    public string Name { get; set; }
    public List<Store> Stores { get; set; }

    public void Load(UnitOfWork unitOfWork)
    {
      Stores = unitOfWork.Stores.Select(t => !string.IsNullOrWhiteSpace(t.Name)).ToList();
    }

  }
}