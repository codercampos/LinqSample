using System.Text.Json.Serialization;

namespace JsonSamples.Models;

public class ProductSpecification
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
}