using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storage;
using PizzaBox.Storage.Repositories;
using System;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]")]
  public class AccountingController : Controller
  {
    private readonly UnitOfWork _unitOfWork;

    public AccountingController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public IActionResult Accounting()
    {
      var accounting = new AccountingViewModel();
      accounting.Load(_unitOfWork);
      return View("Accounting", accounting);
    }
  }
}