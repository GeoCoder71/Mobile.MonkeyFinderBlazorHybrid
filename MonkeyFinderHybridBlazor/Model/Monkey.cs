using System.Text.Json.Serialization;

namespace MonkeyFinderHybridBlazor.Model;

public class Monkey
{
    public string Name { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string Details { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public int Population { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}

/// <summary>
// By default, reflection is used to determine the metadata for an object that needs to be serialized and deserialized with JSON. 
// By enabling the above, we instead use source generation to do this. 
// This will speed up our application and make it compatible with ahead-of-time compilation.
/// </summary>
[JsonSerializable(typeof(List<Monkey>))]
internal sealed partial class MonkeyContext : JsonSerializerContext
{

}