using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;

namespace PostmanCloneLibrary;

public class ApiAccess : IApiAccess
{
    private readonly HttpClient client = new();
    public async Task<string> CallApiAsync(string url, bool formatOutput = true, HttpAction action = HttpAction.GET)
    {
        var res = await client.GetAsync(url);
        if (res.IsSuccessStatusCode)
        {
            string json = await res.Content.ReadAsStringAsync();

            if (formatOutput)
            {
                var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
                json = JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true });
            }
            return json;
        }
        else
        {
            return $"Error: {res.StatusCode}";
        }
    }

    public bool isValidUrl(string url)
    {
        if (string.IsNullOrWhiteSpace(url))
        {
            return false;
        }
        bool output = Uri.TryCreate(url, UriKind.Absolute, out Uri uriOutput)
            && (uriOutput.Scheme == Uri.UriSchemeHttps);

        return output;
    }
}
