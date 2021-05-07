namespace PizzaBox.Domain.Interfaces
{
  public interface PizzaRepository<T> where T : Enumerable<T>
  {
    T Select();
    bool Insert(Size entry);
    T Update();
    public bool Delete()
    {

    }
  }
}