﻿using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace WeatherApp;

public static class WeatherApiManager
{
    private const string ApiKeyFilePath = "ApiKey.txt";
    private const string LocationApiCallFilePath = "LocationApiCall.txt";
    private const string CityApiCallFilePath = "CityApiCall.txt";

    private static readonly string ApiKey;
    private static readonly string CityNameApiCallFormat;
    private static readonly string LocationApiCallFormat;

    private static readonly WebClient WebClient = new();

    static WeatherApiManager()
    {
        ApiKey = LoadApiKey();
        CityNameApiCallFormat = LoadCityNameCallFormat();
        LocationApiCallFormat = LoadLocationCallFormat();
    }

    private static string LoadLocationCallFormat()
    {
        return File.ReadAllText(LocationApiCallFilePath);
    }

    private static string LoadCityNameCallFormat()
    {
        return File.ReadAllText(CityApiCallFilePath);
    }

    private static string LoadApiKey()
    {
        return File.ReadAllText(ApiKeyFilePath);
    }

    private static Weather GetWeatherByJson(JObject weatherJsonObject)
    {
        return new Weather
        {
            Latitude = weatherJsonObject["coord"]!["lat"]!.Value<double>(),
            Longitude = weatherJsonObject["coord"]!["lon"]!.Value<double>(),
            Temperature = weatherJsonObject["main"]!["temp"]!.Value<double>(),
            TemperatureFeelsLike = weatherJsonObject["main"]!["feels_like"]!.Value<double>(),
            Pressure = weatherJsonObject["main"]!["pressure"]!.Value<double>(),
            Humidity = weatherJsonObject["main"]!["humidity"]!.Value<double>(),
            WindSpeed = weatherJsonObject["wind"]!["speed"]!.Value<double>(),
            Description = weatherJsonObject["weather"]![0]!["description"]!.Value<string>()!
        };
    }

    public static Weather GetWeatherByCityName(string cityName)
    {
        var content = WebClient.DownloadString(string.Format(CityNameApiCallFormat, cityName, ApiKey));
        var weatherJsonObject = JObject.Parse(content);
        return GetWeatherByJson(weatherJsonObject);
    }

    public static Weather GetWeatherByLocation(Location location)
    {
        var content = WebClient.DownloadString(
            string.Format(
                LocationApiCallFormat,
                location.Latitude,
                location.Longitude, ApiKey));
        
        var weatherJsonObject = JObject.Parse(content);
        return GetWeatherByJson(weatherJsonObject);
    }
}