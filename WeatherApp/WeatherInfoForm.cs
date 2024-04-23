using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WeatherApp;

public partial class WeatherInfoForm : Form
{
    private WeatherLocation _weatherLocation = null!;

    public WeatherInfoForm()
    {
        InitializeComponent();
        MainForm.WeatherRequested += ShowWeatherData;
    }

    private void ShowWeatherData(WeatherLocation weatherLocation)
    {
        var weather = weatherLocation.Weather;
        latitudeLabel.Text = weather.Latitude.ToString(CultureInfo.CurrentCulture);
        longitudeLabel.Text = weather.Longitude.ToString(CultureInfo.CurrentCulture);
        temperatureLabel.Text = weather.Temperature.ToString(CultureInfo.CurrentCulture);
        feelsLikeLabel.Text = weather.TemperatureFeelsLike.ToString(CultureInfo.CurrentCulture);
        pressureLabel.Text = weather.Pressure.ToString(CultureInfo.CurrentCulture);
        humidityLabel.Text = weather.Humidity.ToString(CultureInfo.CurrentCulture);
        windSpedLabel.Text = weather.WindSpeed.ToString(CultureInfo.CurrentCulture);
        weatherDescriptionLabel.Text = weather.Description;
        _weatherLocation = weatherLocation;
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void exportButton_Click(object sender, EventArgs e)
    {
        var dialog = new SaveFileDialog();
        dialog.Filter = @"wthr files (*.wthr)|*.wthr";
        dialog.OverwritePrompt = true;
        dialog.ShowDialog();
        if (string.IsNullOrWhiteSpace(dialog.FileName))
        {
            return;
        }

        try
        {
            using var stream = File.CreateText(dialog.FileName);
            stream.Write(JsonConvert.SerializeObject(_weatherLocation));
            MessageBox.Show(@"The weather was successfully exported");
        }
        catch
        {
            MessageBox.Show(@"An Error occured while exporting the weather");
        }
    }
}