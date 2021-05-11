using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storage;
using PizzaBox.Storage.Repositories;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]")]
  public class LocationsController : Controller
  {
    private readonly UnitOfWork _unitOfWork;

    public LocationsController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public IActionResult Locations()
    {
      var store = new LocationsViewModel();
      store.Load(_unitOfWork);
      return View("Locations", store);
    }
  }
}