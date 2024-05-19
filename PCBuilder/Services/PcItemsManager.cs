using System.IO;
using System.Text.Json;
using PCBuilder.Model;

namespace PCBuilder.Services;

public class PcItemsManager : IPcItemsManager
{
    public IEnumerable<TPcItem> GetPcItems<TPcItem>(string pcItemsFilePath) where TPcItem : PcItem
    {
        try
        {
            var pcItems = JsonSerializer.Deserialize<IEnumerable<TPcItem>>(File.ReadAllText(pcItemsFilePath));
            if (pcItems == null)
            {
                throw new JsonException();
            }
            return pcItems;
        }
        catch (Exception e) when(e is JsonException or IOException or FileNotFoundException)
        {
            throw new ArgumentException($"An error occured while parsing the specified path. Error: {e}");
        }
    }
}