namespace ClassWork;

public interface IOrderService
{
    Guid AddOrder(OrderEntity order);
    List<OrderEntity> GetOrders();
}