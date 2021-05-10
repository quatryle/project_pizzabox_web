using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storage;
using PizzaBox.Storage.Repositories;
using System;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]")]
  public class MenuController : Controller
  {
    private readonly UnitOfWork _unitOfWork;

    public MenuController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public IActionResult Menu()
    {
      var menu = new PizzaViewModel();
      menu.Load(_unitOfWork);
      return View("MeNu", menu);
    }
  }
}