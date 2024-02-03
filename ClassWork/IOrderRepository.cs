namespace ClassWork;

public interface IOrderRepository
{
    Guid AddOrder(OrderEntity order);
    List<OrderEntity> GetOrders();
    
}