using System.Text.Json;
using System.Text.Json.Serialization;

namespace PatternsHw;

public class SingletonConfigReader
{
    public static string? ConfigFilePath { get; set; }
    
    private static SingletonConfigReader? _instance;

    public static SingletonConfigReader Instance => _instance ??= new SingletonConfigReader();

    private SingletonConfigReader()
    {
        
    }

    public string Read(string key)
    {
        if (ConfigFilePath == null)
        {
            throw new ArgumentException($"Set value to {nameof(ConfigFilePath)} property to call {nameof(Read)} method");
        }

        var jsonRoot = JsonDocument.Parse(File.ReadAllText(ConfigFilePath)).RootElement;
        return jsonRoot.GetProperty(key).GetString()!;
    }
}