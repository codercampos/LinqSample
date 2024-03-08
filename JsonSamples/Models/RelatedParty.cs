using System.Text.Json.Serialization;

namespace JsonSamples.Models;

public class RelatedParty
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = default!;

    [JsonPropertyName("firstName")]
    public string FirstName { get; set; } = default!;

    [JsonPropertyName("middleName")]
    public string MiddleName { get; set; } = default!;

    [JsonPropertyName("lastName")]
    public string LastName { get; set; } = default!;

    [JsonPropertyName("role")]
    public string Role { get; set; } = default!;
}