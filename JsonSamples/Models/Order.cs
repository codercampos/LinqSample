using System.Text.Json.Serialization;

namespace JsonSamples.Models;

public class Order
{
    [JsonPropertyName("externalId")]
    public string ExternalId { get; set; } = default!;

    [JsonPropertyName("requestedCompletionDate")]
    [JsonConverter(typeof(DateTimeConverterUsingDateTimeParse))]
    public DateTime RequestedCompletionDate { get; set; }

    [JsonPropertyName("characteristic")]
    public List<Characteristic> Characteristic { get; set; } = new();

    [JsonPropertyName("relatedParty")]
    public List<RelatedParty> RelatedParty { get; set; } = new();

    [JsonPropertyName("orderItem")]
    public List<OrderItem> OrderItems { get; set; } = new();
}