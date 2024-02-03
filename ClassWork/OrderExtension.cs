namespace ClassWork;

public static class OrderExtension
{
    public static void SortByCreatedAt(this List<OrderEntity> orders)
    {
        int count = orders.Count;
        for (int gap = count / 2; gap > 0; gap /= 2)
        {
            for (int i = gap; i < count; i++)
            {
                var temp = orders[i];
                int j;
                for (j = i; j >= gap && orders[j - gap].CompareTo(temp) > 0; j -= gap)
                {
                    orders[j] = orders[j - gap];
                }

                orders[j] = temp;
            }
        }

        return orders;
    }
    
}