namespace ClassWork;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }
    public Guid AddOrder(OrderEntity order)
    {
        var orderEntity = new OrderEntity()
        {
            CreatedAt = order.CreatedAt,
            IsEmergency = order.IsEmergency
        };
        var id = _orderRepository.AddOrder(orderEntity);
        return id;
    }

    public List<OrderEntity> GetOrders()
    {
        var orderEntities = _orderRepository.GetOrders();
        var order = new List<OrderEntity>();
        foreach (var orderEntity in orderEntities)
        {
            orders.Add(new OrderEntity()
            {
                Id = orderEntity.Id,
                CreatedAt = orderEntity.CreatedAt,
                IsEmergency = orderEntity.IsEmergency
            });
        }

        return orders;
    }

    public List<OrderEntity> GetOrders(bool isDesc)
    {
        return (!isDesc)
            ? GetOrders().SortByCreatedAt()
            : GetOrders();
    }
    public List<OrderEntity> GetOrdersWithEmergency(bool isDesc, bool isEmergencyEnabled)
    {
        var orders = GetOrders(isDesc);
        var emergencyOrder = orders
            .Where(x => x.IsEmergency)
            .ToList();
        emergencyOrder.AddRange(orders);
        return emergencyOrder;
    }
}