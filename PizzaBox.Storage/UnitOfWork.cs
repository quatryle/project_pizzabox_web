using PizzaBox.Storage.Repositories;

namespace PizzaBox.Storage
{
  public class UnitOfWork
  {
    private readonly PizzaBoxContext _context;

    public CrustRepository Crusts { get; }
    public CustomerRepository Customers { get; }
    public OrderRepository Orders { get; }
    public PizzaRepository Pizzas { get; }
    public PresetPizzaRepository PresetPizzas { get; }
    public SizeRepository Sizes { get; }
    public StoreRepository Stores { get; }
    public ToppingRepository Toppings { get; }
    public HistoryRepository History { get; }

    public UnitOfWork(PizzaBoxContext context)
    {
      _context = context;

      Crusts = new CrustRepository(context);
      Customers = new CustomerRepository(context);
      History = new HistoryRepository(context);
      Orders = new OrderRepository(context);
      Sizes = new SizeRepository(context);
      Pizzas = new PizzaRepository(context);
      PresetPizzas = new PresetPizzaRepository(context);
      Stores = new StoreRepository(context);
      Toppings = new ToppingRepository(context);
    }

    public void Save()
    {
      _context.SaveChanges();
    }
  }
}