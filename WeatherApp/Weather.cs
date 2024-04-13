using System;

namespace WeatherApp;

public class Weather
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public double Temperature { get; set; } // Celsius
    public double TemperatureFeelsLike { get; set; } // Celsius
    public double Pressure { get; set; } // hPa
    public double Humidity { get; set; } // %
    public double WindSpeed { get; set; } // meter/sec
    public string Description { get; set; } = string.Empty;
}