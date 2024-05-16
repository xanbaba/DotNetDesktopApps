namespace XanWeather.Model;

public class Weather
{
    public double Latitude { get; init; }
    public double Longitude { get; init; }
    public double Temperature { get; init; } // Celsius
    public double TemperatureFeelsLike { get; init; } // Celsius
    public double Pressure { get; init; } // hPa
    public double Humidity { get; init; } // %
    public double WindSpeed { get; init; } // meter/sec
    public string Description { get; init; } = string.Empty;
}