using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storage;
using PizzaBox.Storage.Repositories;
using System;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]")]
  public class PlacedOrderController : Controller
  {
    private readonly UnitOfWork _unitOfWork;

    public PlacedOrderController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public IActionResult PlacedOrder()
    {
      var placedOrder = new PizzaViewModel();
      placedOrder.Load(_unitOfWork);
      return View("MeNu", placedOrder);
    }
  }
}