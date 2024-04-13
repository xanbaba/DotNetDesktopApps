using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace WeatherApp;

public class WeathersManager
{
    private const string FilePath = "WeatherLocations.json";

    private readonly BindingList<WeatherLocation> _weatherLocations;

    public WeathersManager()
    {
        _weatherLocations = LoadWeatherLocations();
        AddWeatherLocationForm.CityAdded += AddCity;
        AddWeatherLocationForm.LocationAdded += AddLocation;
    }

    private BindingList<WeatherLocation> LoadWeatherLocations()
    {
        if (!File.Exists(FilePath))
        {
            File.Create(FilePath).Close();
        }

        var content = File.ReadAllText(FilePath);
        try
        {
            var weatherLocations = JsonConvert.DeserializeObject<BindingList<WeatherLocation>>(content);
            if (weatherLocations == null)
            {
                throw new JsonReaderException();
            }

            return weatherLocations;
        }
        catch (JsonReaderException)
        {
            File.WriteAllText(FilePath, @"[]");
            return new BindingList<WeatherLocation>();
        }
    }

    private void AddCity(string cityName)
    {
        _weatherLocations.Add(new WeatherLocation
        {
            CityName = cityName,
            Weather = WeatherApiManager.GetWeatherByCityName(cityName)
        });
        SaveToFile();
    }

    private void AddLocation(Location location)
    {
        _weatherLocations.Add(new WeatherLocation
        {
            CityName = null,
            Weather = WeatherApiManager.GetWeatherByLocation(location)
        });
        SaveToFile();
    }

    private void SaveToFile()
    {
        File.WriteAllText(FilePath, JsonConvert.SerializeObject(_weatherLocations));
    }

    public BindingList<WeatherLocation> GetBindingList()
    {
        return _weatherLocations;
    }

    public void RemoveWeatherLocations(IList locationsIndexes)
    {
        var locationsIndexesClone = locationsIndexes.Cast<int>().ToList();
        for (var i = 0; i < _weatherLocations.Count; i++)
        {
            if (!locationsIndexesClone.Contains(i)) continue;
            locationsIndexesClone.Remove(i);
            _weatherLocations.RemoveAt(i);
            for (var j = 0; j < locationsIndexesClone.Count; j++)
            {
                Console.WriteLine(locationsIndexesClone[j]);
                if (locationsIndexesClone[j] > i)
                {
                    locationsIndexesClone[j] -= 1;
                }
                Console.WriteLine(locationsIndexesClone[j]);
            }

            --i;
        }
        SaveToFile();
    }

    public void RefreshWeatherLocations(IList locationsIndexes)
    {
        foreach (int locationsIndex in locationsIndexes)
        {
            var weatherLocation = _weatherLocations[locationsIndex];
            if (weatherLocation.CityName == null)
            {
                weatherLocation.Weather = WeatherApiManager.GetWeatherByLocation(new Location
                {
                    Latitude = weatherLocation.Weather.Latitude,
                    Longitude = weatherLocation.Weather.Longitude
                });
            }
            else
            {
                weatherLocation.Weather = WeatherApiManager.GetWeatherByCityName(weatherLocation.CityName);
            }
        }
        _weatherLocations.ResetBindings();
        SaveToFile();
    }

    public WeatherLocation GetWeatherLocation(int index)
    {
        return _weatherLocations[index];
    }
}