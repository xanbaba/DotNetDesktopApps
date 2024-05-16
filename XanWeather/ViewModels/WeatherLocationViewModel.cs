using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using XanWeather.Messages;
using XanWeather.Model;
using XanWeather.Services;

namespace XanWeather.ViewModels;

public partial class WeatherLocationViewModel(WeatherLocation weatherLocation, ViewModelFactory factory) : BaseViewModel
{
    public WeatherLocation WeatherLocation { get; } = weatherLocation;

    [ObservableProperty] private string? _cityName = weatherLocation.CityName;
    [ObservableProperty] private Weather _weather = weatherLocation.Weather;
    [ObservableProperty] private bool _isChecked;

    public string LocationTemplate => CityName ?? $"Lat: {Weather.Latitude} Lon: {Weather.Longitude}";
    public string WeatherTemperatureTemplate => $"{Weather.Temperature} C";
    
    [RelayCommand]
    private void OpenMoreInfo()
    {
        WeakReferenceMessenger.Default.Send(new ChangeViewModelMessage(new WeatherInformationViewModel(this, factory)));
    }
}