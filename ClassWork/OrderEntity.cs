namespace ClassWork;

public class OrderEntity : IComparable<OrderEntity>
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsEmergency { get; set; }

    public int CompareTo(OrderEntity? otherOrder)
    {
        
    }

    public int CompareTo(OrderEntity? order)
    {
        return CreatedAt.CompareTo(order?.CreatedAt);
    }

    public override string ToString()
    {
        return $"Order id: {Id} was created at {CreatedAt}. Is order emergency {IsEmergency}";
    }
 }