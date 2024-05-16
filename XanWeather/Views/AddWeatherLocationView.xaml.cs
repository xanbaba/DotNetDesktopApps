using System.Windows;
using System.Windows.Input;

namespace XanWeather.Views;

public partial class AddWeatherLocationView
{
    #region CityName

    public static readonly DependencyProperty CityNameGotFocusCommandProperty = DependencyProperty.Register(
        nameof(CityNameGotFocusCommand), typeof(ICommand), typeof(AddWeatherLocationView),
        new PropertyMetadata(default(ICommand)));

    public ICommand? CityNameGotFocusCommand
    {
        get => (ICommand)GetValue(CityNameGotFocusCommandProperty);
        set => SetValue(CityNameGotFocusCommandProperty, value);
    }

    public static readonly DependencyProperty CityNameLostFocusCommandProperty = DependencyProperty.Register(
        nameof(CityNameLostFocusCommand), typeof(ICommand), typeof(AddWeatherLocationView),
        new PropertyMetadata(default(ICommand)));

    public ICommand? CityNameLostFocusCommand
    {
        get => (ICommand)GetValue(CityNameLostFocusCommandProperty);
        set => SetValue(CityNameLostFocusCommandProperty, value);
    }

    #endregion

    #region Latitude
    
    public static readonly DependencyProperty LatitudeGotFocusCommandProperty = DependencyProperty.Register(
        nameof(LatitudeGotFocusCommand), typeof(ICommand), typeof(AddWeatherLocationView),
        new PropertyMetadata(default(ICommand)));

    public ICommand? LatitudeGotFocusCommand
    {
        get => (ICommand)GetValue(LatitudeGotFocusCommandProperty);
        set => SetValue(LatitudeGotFocusCommandProperty, value);
    }

    public static readonly DependencyProperty LatitudeLostFocusCommandProperty = DependencyProperty.Register(
        nameof(LatitudeLostFocusCommand), typeof(ICommand), typeof(AddWeatherLocationView), new PropertyMetadata(default(ICommand)));

    public ICommand? LatitudeLostFocusCommand
    {
        get => (ICommand)GetValue(LatitudeLostFocusCommandProperty);
        set => SetValue(LatitudeLostFocusCommandProperty, value);
    }
    #endregion

    #region Longitude

    public static readonly DependencyProperty LongitudeGotFocusCommandProperty = DependencyProperty.Register(
        nameof(LongitudeGotFocusCommand), typeof(ICommand), typeof(AddWeatherLocationView), new PropertyMetadata(default(ICommand)));

    public ICommand? LongitudeGotFocusCommand
    {
        get => (ICommand)GetValue(LongitudeGotFocusCommandProperty);
        set => SetValue(LongitudeGotFocusCommandProperty, value);
    }

    public static readonly DependencyProperty LongitudeLostFocusCommandProperty = DependencyProperty.Register(
        nameof(LongitudeLostFocusCommand), typeof(ICommand), typeof(AddWeatherLocationView), new PropertyMetadata(default(ICommand)));

    public ICommand? LongitudeLostFocusCommand
    {
        get => (ICommand)GetValue(LongitudeLostFocusCommandProperty);
        set => SetValue(LongitudeLostFocusCommandProperty, value);
    }

    #endregion

    public AddWeatherLocationView()
    {
        InitializeComponent();
    }

    private void CityNameTextBox_OnGotFocus(object sender, RoutedEventArgs e)
    {
        CityNameGotFocusCommand?.Execute(null);
    }

    private void CityNameTextBox_OnLostFocus(object sender, RoutedEventArgs e)
    {
        CityNameLostFocusCommand?.Execute(null);
    }

    private void LatitudeTextBox_OnGotFocus(object sender, RoutedEventArgs e)
    {
        LatitudeGotFocusCommand?.Execute(null);
    }

    private void LatitudeTextBox_OnLostFocus(object sender, RoutedEventArgs e)
    {
        LatitudeLostFocusCommand?.Execute(null);
    }

    private void LongitudeTextBox_OnGotFocus(object sender, RoutedEventArgs e)
    {
        LongitudeGotFocusCommand?.Execute(null);
    }

    private void Longitude_OnLostFocus(object sender, RoutedEventArgs e)
    {
        LongitudeLostFocusCommand?.Execute(null);
    }
}