using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storage;
using PizzaBox.Storage.Repositories;

namespace PizzaBox.Client.Models
{
  public class PizzaViewModel
  {
    public string Name { get; set; }
    public List<PresetPizza> PresetPizzas { get; set; }

    public void Load(UnitOfWork unitOfWork)
    {
      PresetPizzas = unitOfWork.PresetPizzas.Select(t => !string.IsNullOrWhiteSpace(t.Name)).ToList();
      System.Console.WriteLine("Preset pizzas obtained");
    }

  }
}