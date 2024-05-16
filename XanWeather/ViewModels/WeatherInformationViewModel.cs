using System.IO;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Win32;
using XanWeather.Messages;
using XanWeather.Services;

namespace XanWeather.ViewModels;

public partial class WeatherInformationViewModel : BaseViewModel
{
    private readonly ViewModelFactory _factory;

    public WeatherInformationViewModel(WeatherLocationViewModel weatherLocationViewModel, ViewModelFactory factory)
    {
        _factory = factory;
        CityName = weatherLocationViewModel.CityName;
        Latitude = weatherLocationViewModel.Weather.Latitude;
        Longitude = weatherLocationViewModel.Weather.Longitude;
        Temperature = weatherLocationViewModel.Weather.Temperature;
        TemperatureFeelsLike = weatherLocationViewModel.Weather.TemperatureFeelsLike;
        Pressure = weatherLocationViewModel.Weather.Pressure;
        Humidity = weatherLocationViewModel.Weather.Humidity;
        WindSpeed = weatherLocationViewModel.Weather.WindSpeed;
        Description = weatherLocationViewModel.Weather.Description;
    }

    [ObservableProperty] private string? _cityName = string.Empty;
    [ObservableProperty] private double _latitude;
    [ObservableProperty] private double _longitude;
    [ObservableProperty] private double _temperature;
    [ObservableProperty] private double _temperatureFeelsLike;
    [ObservableProperty] private double _pressure;
    [ObservableProperty] private double _humidity;
    [ObservableProperty] private double _windSpeed;
    [ObservableProperty] private string _description = string.Empty;

    [RelayCommand]
    private void Back()
    {
        WeakReferenceMessenger.Default.Send(new ChangeViewModelMessage(_factory.Create<WeatherLocationsViewModel>()));
    }

    [RelayCommand]
    private void Save()
    {
        var dialog = new SaveFileDialog
        {
            Filter = "Text file|*.txt|All files|*.*",
            OverwritePrompt = true
        };
        dialog.ShowDialog();
        if (string.IsNullOrWhiteSpace(dialog.FileName))
        {
            return;
        }
        File.WriteAllText(dialog.FileName,
            $"{nameof(CityName)}: {CityName} \n" +
            $"{nameof(Latitude)}: {Latitude} \n" +
            $"{nameof(Longitude)}: {Longitude} \n" +
            $"{nameof(Temperature)}: {Temperature} \n" +
            $"{nameof(TemperatureFeelsLike)}: {TemperatureFeelsLike} \n" +
            $"{nameof(Pressure)}: {Pressure} \n" +
            $"{nameof(Humidity)}: {Humidity} \n" +
            $"{nameof(WindSpeed)}: {WindSpeed} \n" +
            $"{nameof(Description)}: {Description} \n");
        
        MessageBox.Show("Weather info was successfully saved!", "Info");
    }
}