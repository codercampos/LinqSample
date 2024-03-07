using System.Text.Json.Serialization;

namespace JsonSamples.Models;

public class Characteristic
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("value")]
    public List<object> Value { get; set; }
}