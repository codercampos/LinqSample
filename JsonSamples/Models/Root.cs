using System.Text.Json.Serialization;

namespace JsonSamples.Models;

public class Root
{
    [JsonPropertyName("externalId")]
    public string ExternalId { get; set; }

    [JsonPropertyName("requestedCompletionDate")]
    [JsonConverter(typeof(DateTimeConverterUsingDateTimeParse))]
    public DateTime RequestedCompletionDate { get; set; }

    [JsonPropertyName("characteristic")]
    public List<Characteristic> Characteristic { get; set; }

    [JsonPropertyName("relatedParty")]
    public List<RelatedParty> RelatedParty { get; set; }

    [JsonPropertyName("orderItem")]
    public List<OrderItem> OrderItem { get; set; }
}