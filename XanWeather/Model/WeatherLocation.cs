namespace XanWeather.Model;

public class WeatherLocation
{
    public string? CityName { get; set; }
    public Weather Weather { get; set; } = null!;
    public override string ToString()
    {
        if (CityName != null)
        {
            return CityName.PadRight(50) + $"{Weather.Temperature}C";
        }

        return $"Lat:{Weather.Latitude}    Lon:{Weather.Longitude}".PadRight(50) + $"{Weather.Temperature}C";
    }
}