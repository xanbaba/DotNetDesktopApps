using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using XanWeather.Messages;
using XanWeather.Model;
using XanWeather.Services;

namespace XanWeather.ViewModels;

public partial class WeatherLocationsViewModel : BaseViewModel
{
    private readonly ViewModelFactory _factory;
    private readonly IWeatherLocationsManager _weatherLocationsManager;
    [ObservableProperty] private ObservableCollection<WeatherLocationViewModel> _weatherLocationsViewModels;

    public WeatherLocationsViewModel(ViewModelFactory factory, IWeatherLocationsManager weatherLocationsManager)
    {
        _factory = factory;
        _weatherLocationsManager = weatherLocationsManager;
        WeatherLocationsViewModels = [];
        RefreshWeatherLocations();
        WeakReferenceMessenger.Default.Register<AddWeatherLocationMessage>(this, AddWeatherLocation);
    }

    private void RefreshWeatherLocations()
    {
        WeatherLocationsViewModels.Clear();
        foreach (var location in _weatherLocationsManager.GetAllWeatherLocations())
        {
            WeatherLocationsViewModels.Add(new WeatherLocationViewModel(location, _factory));
        }
    }

    private void AddWeatherLocation(object recipient, AddWeatherLocationMessage message)
    {
        if (_weatherLocationsManager.AddWeatherLocation(message.WeatherLocation))
        {
            RefreshWeatherLocations();
        }
    }

    [RelayCommand]
    private void Add()
    {
        WeakReferenceMessenger.Default.Send(new ChangeViewModelMessage(_factory.Create<AddWeatherLocationViewModel>()));
    }

    [RelayCommand]
    private void Remove()
    {
        var itemsToRemove = WeatherLocationsViewModels.Where(weather => weather.IsChecked).ToList();

        foreach (var itemToRemove in itemsToRemove)
        {
            _weatherLocationsManager.RemoveWeatherLocation(itemToRemove.WeatherLocation);
        }
        RefreshWeatherLocations();
    }

    [RelayCommand]
    private void Refresh()
    {
        var itemsToRefresh = WeatherLocationsViewModels.Where(weather => weather.IsChecked).ToList();
        foreach (var itemToRefresh in itemsToRefresh)
        {
            _weatherLocationsManager.RefreshWeatherLocation(itemToRefresh.WeatherLocation);
        }
        RefreshWeatherLocations();
    }
}