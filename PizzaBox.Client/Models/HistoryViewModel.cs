using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storage;
using PizzaBox.Storage.Repositories;

namespace PizzaBox.Client.Models
{
  public class HistoryViewModel
  {
    public string Name { get; set; }
    public List<OrderHistory> History { get; set; }

    public void Load(UnitOfWork unitOfWork)
    {
      History = unitOfWork.History.Select(t => !string.IsNullOrWhiteSpace(t.PizzaName)).ToList();
    }

  }
}