using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class PresetPizza : Entity
  {
    public string Name { get; set; }
    public string Crust { get; set; }
    public string Top1 { get; set; }
    public string Top2 { get; set; }
    public string Top3 { get; set; }
    public string Top4 { get; set; }
    public string Top5 { get; set; }
    public string Top6 { get; set; }
    public string Top7 { get; set; }
    public override string ToString()
    {
      return $"{Name} - {Crust} Crust, {Top1} {Top2} {Top3} {Top4} {Top5} {Top6} {Top7}";
    }
  }
}