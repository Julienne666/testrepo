namespace ClassWork;

public class OrderRepository : IOrderRepository
{
    private List<OrderEntity> orders = new List<OrderEntity>();

    public OrderRepository()
    {
        orders = new List<OrderEntity>()
        {
            new OrderEntity()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow.AddHours()
            }
        }
    }
    public Guid AddOrder(OrderEntity order)
    {
        order.Id = Guid.NewGuid();
        orders.Add(order);
        return order.Id;
    }

    public List<OrderEntity> GetOrders()
    {
        return orders;
    }
}