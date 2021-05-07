using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;


namespace PizzaBox.Client.Controlelrs
{
  [Route("[controller]")]
  public class OrderController : Controllers
  {
    private readonly UnitOfWork _unitofWork;

    public OrderController(UnitOfWork unitOfWork)
    {
      _unitofWork = unitOfWork;
    }




    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(OrderViewModel order)
    {
      if (ModelState.IsValid)
      {
        var crust = _unitofWork.Crusts.Select(c => c.Name == order.SelectedCrust).First();
        var size = _unitofWork.Size.Select(s => s.Name == order.SelectedSize).First();
        var toppings = new List<Topping>();

        foreach (var item in order.Toppings)
        {
          toppings.Add(_unitofWork.Toppings.Select(t => t.Name == order.SelectedToppings).First());
        }

        var newPizza = new PizzaBox { Crust = crust, Size = size, Toppings = toppings };
        var newOrder = new OrderController { Pizzas = new List<PizzaBox> { newPizza } };

        _unitofWork.Orders.Insert(newOrder);
        _unitofWork.Save();

        ViewBag.Order = newOrder;

        return View("checkout");
      }
      order.Load(_unitofWork);
      return View("order", order);
    }
  }
}
