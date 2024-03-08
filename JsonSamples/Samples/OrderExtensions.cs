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
        // TODO Which data are we going to show?
        foreach (Order order in result)
        {
            Console.WriteLine($"{order.ExternalId} | Date: {order.RequestedCompletionDate.ToLongDateString()} | OrderItems: {order.OrderItems.Count}");
        }
    }
}