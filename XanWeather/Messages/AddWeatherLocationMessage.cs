using XanWeather.Model;

namespace XanWeather.Messages;

public class AddWeatherLocationMessage(WeatherLocation weatherLocation)
{
    public WeatherLocation WeatherLocation { get; set; } = weatherLocation;
}