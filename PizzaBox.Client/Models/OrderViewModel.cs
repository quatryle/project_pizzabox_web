using System.Collections.Generic;

namespace PizzaBox.Client.Models
{
  public class OrderViewModel
  {
    public List<Crust> Crusts { get; set; }
    public List<Size> Sizes { get; set; }
    public List<Toppings> Toppings { get; set; }
    [Required(ErrorMessage = "Crust Error")]
    [DataType(DataType.Text)]
    public string SelectedCrust { get; set; }
    [Required(ErrorMessage = "Size Error")]
    [DataType(DataType.Text)]
    public string SelectedSize { get; set; }
    [Required(ErrorMessage = "Topping Error")]
    public List<string> SelectedToppings { get; set; }

    public void Load(UnitOfWork unitOfWork)
    {
      Crusts = unitOfWork.Crust.Select(c => c.EntityId > 0).ToList();
      Sizes = unitOfWork.Size.Select(c => c.EntityId > 0).ToList();
      Toppings = unitOfWork.Topping.Select(c => c.EntityId > 0).ToList();
    }
    public IEnumerable<crust> Where(List<Crust> crusts)
    {

    }
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      if (SelectedToppings.Count < 2 || SelectedToppings.Count > 5)
      {
        yield return new ValidationResult("please select at least 2, but no more than 5 toppings");
      }
    }
  }
}