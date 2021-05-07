using System.Collections.Generic;
namespace PizzaBox.Domain.Interfaces
{
  public interface Irepository<T> where T : Enumerable<T>
  {
    public T Insert();
    public T Select();
    public T Update();
    public T Delete();
  }
}