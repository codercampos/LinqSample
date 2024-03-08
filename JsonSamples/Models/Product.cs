using System.Text.Json.Serialization;

namespace JsonSamples.Models;

public class Product
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = default!;
    [JsonPropertyName("productSpecification")]
    public ProductSpecification? ProductSpecification { get; set; }
    [JsonPropertyName("characteristic")]
    public List<Characteristic> Characteristic { get; set; } = new();
}