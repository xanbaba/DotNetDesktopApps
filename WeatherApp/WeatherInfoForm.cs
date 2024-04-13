using System;
using System.Globalization;
using System.Windows.Forms;

namespace WeatherApp;

public partial class WeatherInfoForm : Form
{
    public WeatherInfoForm()
    {
        InitializeComponent();
        MainForm.WeatherRequested += ShowWeatherData;
    }

    private void ShowWeatherData(Weather weather)
    {
        latitudeLabel.Text = weather.Latitude.ToString(CultureInfo.CurrentCulture);
        longitudeLabel.Text = weather.Longitude.ToString(CultureInfo.CurrentCulture);
        temperatureLabel.Text = weather.Temperature.ToString(CultureInfo.CurrentCulture);
        feelsLikeLabel.Text = weather.TemperatureFeelsLike.ToString(CultureInfo.CurrentCulture);
        pressureLabel.Text = weather.Pressure.ToString(CultureInfo.CurrentCulture);
        humidityLabel.Text = weather.Humidity.ToString(CultureInfo.CurrentCulture);
        windSpedLabel.Text = weather.WindSpeed.ToString(CultureInfo.CurrentCulture);
        weatherDescriptionLabel.Text = weather.Description;
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
        Close();
    }
}