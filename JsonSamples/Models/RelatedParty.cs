using System.Text.Json.Serialization;

namespace JsonSamples.Models;

public class RelatedParty
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("firstName")]
    public string FirstName { get; set; }

    [JsonPropertyName("middleName")]
    public string MiddleName { get; set; }

    [JsonPropertyName("lastName")]
    public string LastName { get; set; }

    [JsonPropertyName("role")]
    public string Role { get; set; }
}