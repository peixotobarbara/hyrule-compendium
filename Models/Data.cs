using System.Text.Json.Serialization;

namespace HyruleCompendium.Models;
public class Data
{
    public int Id { get; set; }
    public string Category { get; set; } = string.Empty;

    [JsonPropertyName("common_locations")]
    public string[] CommonLocations { get; set; } = Array.Empty<string>();
    public string Description { get; set; } = string.Empty;
    public string[] Drops { get; set; } = Array.Empty<string>();
    public string Image { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;

}