// See https://aka.ms/new-console-template for more information
using JsonSamples.Models;
using System.Text.Json;
using JsonSamples.Samples;

namespace JsonSamples;

public static class Program
{
    public static void Main(string[] _)
    {
        Console.WriteLine("Hello! We are going to read a collection of json files, do queries on LINQ and to return specific data.");

        DirectoryInfo directoryInfo = new("JsonFiles");
        if (!directoryInfo.Exists) return;
        FileInfo[] files = directoryInfo.GetFiles("*.json");
        List<Order> orders = new List<Order>();
        foreach (FileInfo fileInfo in files)
        {
            string json = File.ReadAllText(Path.Combine(fileInfo.Directory!.FullName, fileInfo.Name));
            Order? root = JsonSerializer.Deserialize<Order>(json, JsonSerializerOptions.Default);

            if (root is not null)
            {
                orders.Add(root);
            }
        }

        DateTime startDate = DateTime.Now.AddYears(-3);
        DateTime endDate = DateTime.Now;
        orders.SelectOrdersByRange(startDate, endDate);
    }
}