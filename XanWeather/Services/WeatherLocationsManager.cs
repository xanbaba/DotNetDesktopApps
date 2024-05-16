using System.IO;
using System.Text.Json;
using XanWeather.Model;
using XanWeather.Services.WeatherApi;

namespace XanWeather.Services;

public class WeatherLocationsManager : IWeatherLocationsManager
{
    private const string WeatherLocationsFilePath = "WeatherLocations.json";

    private readonly List<WeatherLocation> _weatherLocations;

    public WeatherLocationsManager()
    {
        _weatherLocations = LoadAllWeatherLocations();
    }

    private List<WeatherLocation> LoadAllWeatherLocations()
    {
        if (!File.Exists(WeatherLocationsFilePath))
        {
            ResetDataBase();
        }

        var content = File.ReadAllText(WeatherLocationsFilePath);
        try
        {
            var weatherLocations = JsonSerializer.Deserialize<List<WeatherLocation>>(content);
            if (weatherLocations == null)
            {
                throw new JsonException();
            }
            return weatherLocations;
        }
        catch (JsonException)
        {
            ResetDataBase();
        }

        return [];
    }

    private void ResetDataBase()
    {
        File.WriteAllText(WeatherLocationsFilePath, "[]");
    }
    public IEnumerable<WeatherLocation> GetAllWeatherLocations()
    {
        return _weatherLocations;
    }

    public bool AddWeatherLocation(WeatherLocation weatherLocation)
    {
        if (_weatherLocations.Count(location =>
            {
                if (location.CityName == null)
                {
                    return false;
                }
                return location.CityName == weatherLocation.CityName;
            }) == 0)
        {
            Console.WriteLine("Added");
            _weatherLocations.Add(weatherLocation);
            SaveToFile();
            return true;
        }

        return false;
    }

    public void RemoveWeatherLocation(WeatherLocation weatherLocation)
    {
        _weatherLocations.Remove(weatherLocation);
        SaveToFile();
    }

    public void RefreshWeatherLocation(WeatherLocation weatherLocation)
    {
        var location = _weatherLocations.Find(w => w == weatherLocation);
        if (location == null)
        {
            throw new ArgumentException("Weather location was not found!");
        }

        if (location.CityName != null)
        {
            location.Weather = WeatherApiManager.GetWeatherByCityName(location.CityName);
        }
        else
        {
            location.Weather = WeatherApiManager.GetWeatherByLocation(new Location
            {
                Latitude = location.Weather.Latitude,
                Longitude = location.Weather.Longitude
            });
        }
        SaveToFile();
    }

    private void SaveToFile()
    {
        File.WriteAllText(WeatherLocationsFilePath, JsonSerializer.Serialize<IEnumerable<WeatherLocation>>(_weatherLocations));
    }
}