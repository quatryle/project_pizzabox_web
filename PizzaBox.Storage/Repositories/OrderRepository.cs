namespace PizzaBox.Storage.Repositories
{
  public class OrderRepository : IRepository<OrderRepository>
  {
    public void Delete()
    {
      throw new System.NotImplementedException();
    }
    public void Insert(Order order)
    {
      _context.Orders.Add(order);
    }
    public void Select()
    {
      throw new System.NotImplementedException();
    }
    public void Update()
    {
      throw new System.NotImplementedException();
    }
  }
}