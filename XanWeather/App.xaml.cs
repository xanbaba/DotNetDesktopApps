using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using XanWeather.Services;
using XanWeather.ViewModels;
using XanWeather.Views;

namespace XanWeather;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
    protected override void OnStartup(StartupEventArgs e)
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddSingleton<MainView>();
        serviceCollection.AddSingleton<MainViewModel>();
        serviceCollection.AddSingleton<WeatherLocationsViewModel>();
        serviceCollection.AddTransient<AddWeatherLocationViewModel>();
        serviceCollection.AddTransient<ViewModelFactory>();
        serviceCollection.AddSingleton<IWeatherLocationsManager, WeatherLocationsManager>();

        var serviceProvider = serviceCollection.BuildServiceProvider();
        ServiceProvider = serviceProvider;

        MainWindow = ServiceProvider.GetService<MainView>()!;
        MainWindow.DataContext = ServiceProvider.GetService<MainViewModel>();

        MainWindow.ShowDialog();
        
        base.OnStartup(e);
    }

    public static ServiceProvider ServiceProvider { get; private set; } = null!;
}