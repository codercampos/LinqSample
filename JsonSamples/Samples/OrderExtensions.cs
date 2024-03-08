using JsonSamples.Models;

namespace JsonSamples.Samples;

public static class OrderExtensions
{
    public static void SelectOrdersByRange(this IList<Order> orders, DateTime startDate, DateTime endDate)
    {
        var result = from order in orders
            where order.RequestedCompletionDate >= startDate &&
                  order.RequestedCompletionDate <= endDate
            select order;
        
        Console.WriteLine("1. Select orders by range");
        foreach (Order order in result)
        {
            Console.WriteLine($"{order.ExternalId} | Date: {order.RequestedCompletionDate.ToLongDateString()} | OrderItems: {order.OrderItems.Count}");
        }
        Console.WriteLine("");
    }

    public static void SelectOrdersAdded(this IList<Order> orders)
    {
        var result = (from order in orders
            where order.OrderItems.Any(x => x.Action == "add")
            select order).ToList();

        result.ForEach(x =>
        {
            List<OrderItem> orderItems = new();
            foreach (OrderItem orderItem in x.OrderItems)
            {
                if (orderItem.Action == "add")
                {
                    orderItems.Add(orderItem);
                }
                
                x.OrderItems = orderItems;
            }
        });
        
        Console.WriteLine("2. Select orders that have components added");
        foreach (Order order in result)
        {
            Console.WriteLine($"{order.ExternalId} | Date: {order.RequestedCompletionDate.ToLongDateString()} | OrderItems: {string.Join(", ", order.OrderItems.Select(x => x.Id))}");
        }
    }
}