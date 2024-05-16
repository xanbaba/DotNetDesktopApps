using XanWeather.Model;

namespace XanWeather.Services;

public interface IWeatherLocationsManager
{
    IEnumerable<WeatherLocation> GetAllWeatherLocations();
    bool AddWeatherLocation(WeatherLocation weatherLocation);
    void RemoveWeatherLocation(WeatherLocation weatherLocation);
    void RefreshWeatherLocation(WeatherLocation weatherLocation);
}