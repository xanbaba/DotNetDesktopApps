using System.Net;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using XanWeather.Messages;
using XanWeather.Model;
using XanWeather.Services;
using XanWeather.Services.WeatherApi;
using Timer = System.Timers.Timer;

namespace XanWeather.ViewModels;

public partial class AddWeatherLocationViewModel(ViewModelFactory factory) : BaseViewModel
{
    private const string CityNamePlaceholder = "City Name";
    private const string LatitudePlaceholder = "Latitude";
    private const string LongitudePlaceholder = "Longitude";
    
    private const string CoordsParsingErrorMessage = "Format of latitude or longitude is not correct!";
    private const string LocationNotFoundErrorMessage = "The location was not found!";

    [ObservableProperty] private string _cityNameTextBoxText = CityNamePlaceholder;
    [ObservableProperty] private string _latitudeTextBoxText = LatitudePlaceholder;
    [ObservableProperty] private string _longitudeTextBoxText = LongitudePlaceholder;
    
    [ObservableProperty] private string _errorMessageBinding = string.Empty;
    
    [ObservableProperty] private bool _isCityOptionEnabled = true;
    [ObservableProperty] private bool _isCoordOptionEnabled;

    [RelayCommand]
    private void GotCityNameFocus()
    {
        if (CityNameTextBoxText == CityNamePlaceholder)
        {
            CityNameTextBoxText = string.Empty;
        }
    }
    
    [RelayCommand]
    private void LostCityNameFocus()
    {
        if (string.IsNullOrWhiteSpace(CityNameTextBoxText))
        {
            CityNameTextBoxText = CityNamePlaceholder;
        }
    }
    
    [RelayCommand]
    private void GotLatitudeFocus()
    {
        if (LatitudeTextBoxText == LatitudePlaceholder)
        {
            LatitudeTextBoxText = string.Empty;
        }
    }
    
    [RelayCommand]
    private void LostLatitudeFocus()
    {
        if (string.IsNullOrWhiteSpace(LatitudeTextBoxText))
        {
            LatitudeTextBoxText = LatitudePlaceholder;
        }
    }
    
    [RelayCommand]
    private void GotLongitudeFocus()
    {
        if (LongitudeTextBoxText == LongitudePlaceholder)
        {
            LongitudeTextBoxText = string.Empty;
        }
    }
    
    [RelayCommand]
    private void LostLongitudeFocus()
    {
        if (string.IsNullOrWhiteSpace(LongitudeTextBoxText))
        {
            LongitudeTextBoxText = LongitudePlaceholder;
        }
    }

    [RelayCommand]
    private void Back()
    {
        WeakReferenceMessenger.Default.Send(new ChangeViewModelMessage(factory.Create<WeatherLocationsViewModel>()));
    }

    [RelayCommand]
    private void Add()
    {
        WeatherLocation weatherLocation;
        if (IsCityOptionEnabled)
        {
            try
            {
                weatherLocation = new WeatherLocation
                {
                    CityName = CityNameTextBoxText,
                    Weather = WeatherApiManager.GetWeatherByCityName(CityNameTextBoxText)
                };
            }
            catch (WebException)
            {
                HandleException(LocationNotFoundErrorMessage);
                return;
            }
        }
        else
        {
            try
            {
                weatherLocation = new WeatherLocation
                {
                    CityName = null,
                    Weather = WeatherApiManager.GetWeatherByLocation(new Location
                    {
                        Latitude = double.Parse(LatitudeTextBoxText),
                        Longitude = double.Parse(LongitudeTextBoxText)
                    })
                };
            }
            catch (FormatException)
            {
                HandleException(CoordsParsingErrorMessage);
                return;
            }
            catch (WebException)
            {
                HandleException(LocationNotFoundErrorMessage);
                return;
            }
            
        }

        WeakReferenceMessenger.Default.Send(new AddWeatherLocationMessage(weatherLocation));
        Back();
    }

    private void HandleException(string errorMessage)
    {
        var timer = new Timer();
        timer.Interval = 5000;
        timer.Elapsed += (_, _) =>
        {
            ErrorMessageBinding = string.Empty;
        };

        ErrorMessageBinding = errorMessage;
        timer.AutoReset = false;
        timer.Start();
    }
}