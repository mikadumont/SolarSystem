using System.Text.Json;
using System.Text.Json.Serialization;

namespace SolarSystem;

internal record Astronomer(string FirstName, string LastName, string? MiddleName = null);

[JsonSerializable(typeof(Astronomer))]
internal partial class AstronomerJsonContext : JsonSerializerContext
{
}

class Program
{
    static void M(string[] args)
    {
        var astronomer = new Astronomer(FirstName: "Jane", LastName: "Doe");

        string json = JsonSerializer.Serialize(astronomer, AstronomerJsonContext.Default.Astronomer);
    }
}