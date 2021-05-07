using PizzaBox.Storage.Repositories;
namespace PizzaBox.Storage
{
  public class UnitOfWork
  {
    private readonly PizzaBoxContext _context;
    public CrustRepository Crusts { get; }
    public OrderRepository Crusts { get; }
    public PizzaRepository Crusts { get; }
    public SizeRepository Sizes { get; }
    public ToppingRepository Toppings { get; }
    public UnitOfWork(PizzaBoxContext context)
    {
      _context = context;

      Crusts = new CrustRepository(context);
      Orders = new OrderRepository(context);
      Sizes = new SizeRepository(context);
      Pizzas = new PizzaRepository(context);
      Toppings = new ToppingRepository(context);
    }
    public void Save()
    {
      _context.SaveChanges();
    }
  }
}

