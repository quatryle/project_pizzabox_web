using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storage;
using PizzaBox.Storage.Repositories;
using System;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]")]
  public class HistoryController : Controller
  {
    private readonly UnitOfWork _unitOfWork;

    public HistoryController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public IActionResult History()
    {
      var history = new HistoryViewModel();
      history.Load(_unitOfWork);
      return View("History", history);
    }
  }
}