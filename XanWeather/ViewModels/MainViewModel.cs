using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using XanWeather.Messages;
using XanWeather.Services;

namespace XanWeather.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    [ObservableProperty] private BaseViewModel _currentViewModel;

    public MainViewModel(ViewModelFactory viewModelFactory)
    {
        _currentViewModel = viewModelFactory.Create<WeatherLocationsViewModel>();
        WeakReferenceMessenger.Default.Register<ChangeViewModelMessage>(this, ChangeViewModel);
    }

    private void ChangeViewModel(object recipient, ChangeViewModelMessage message)
    {
        CurrentViewModel = message.BaseViewModel;
    }
}