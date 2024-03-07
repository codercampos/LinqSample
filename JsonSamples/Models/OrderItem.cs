using System.Text.Json.Serialization;

namespace JsonSamples.Models;

public class OrderItem
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    [JsonPropertyName("action")]
    public string Action { get; set; }
    [JsonPropertyName("product")]
    public Product Product { get; set; }
}