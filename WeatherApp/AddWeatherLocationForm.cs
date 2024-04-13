using System;
using System.Net;
using System.Windows.Forms;

namespace WeatherApp;

public partial class AddWeatherLocationForm : Form
{
    private const string CityNamePlaceholder = "Enter city name";
    private const string LatitudePlaceholder = "Enter latitude";
    private const string LongitudePlaceholder = "Enter longitude";

    private const string LocationNotFoundErrorMessage = "Location not found!";
    private const string FieldsNotFulledErrorMessage = "Complete all required fields!";

    public static event Action<string>? CityAdded; // string cityName
    public static event Action<Location>? LocationAdded; // double latitude, double longitude

    private readonly Timer _errorMessageTimer = new()
    {
        Interval = 5000
    };

    public AddWeatherLocationForm()
    {
        InitializeComponent();

        // cityNameTextBox
        cityNameTextBox.Text = CityNamePlaceholder;
        cityNameTextBox.GotFocus += RemoveCityNamePlaceholder;
        cityNameTextBox.LostFocus += SetCityNamePlaceholder;

        // latitudeTextBox
        latitudeTextBox.Text = LatitudePlaceholder;
        latitudeTextBox.GotFocus += RemoveLatitudePlaceholder;
        latitudeTextBox.LostFocus += SetLatitudePlaceholder;

        // longitudeTextBox
        longitudeTextBox.Text = LongitudePlaceholder;
        longitudeTextBox.GotFocus += RemoveLongitudePlaceholder;
        longitudeTextBox.LostFocus += SetLongitudePlaceholder;
    }

    private void SetCityNamePlaceholder(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(cityNameTextBox.Text))
        {
            cityNameTextBox.Text = CityNamePlaceholder;
        }
    }

    private void RemoveCityNamePlaceholder(object sender, EventArgs e)
    {
        if (cityNameTextBox.Text == CityNamePlaceholder)
        {
            cityNameTextBox.Text = string.Empty;
        }
    }

    private void SetLatitudePlaceholder(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(latitudeTextBox.Text))
        {
            latitudeTextBox.Text = LatitudePlaceholder;
        }
    }

    private void RemoveLatitudePlaceholder(object sender, EventArgs e)
    {
        if (latitudeTextBox.Text == LatitudePlaceholder)
        {
            latitudeTextBox.Text = string.Empty;
        }
    }

    private void SetLongitudePlaceholder(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(longitudeTextBox.Text))
        {
            longitudeTextBox.Text = LongitudePlaceholder;
        }
    }

    private void RemoveLongitudePlaceholder(object sender, EventArgs e)
    {
        if (longitudeTextBox.Text == LongitudePlaceholder)
        {
            longitudeTextBox.Text = string.Empty;
        }
    }

    private void cityNameRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        cityNamePanel.Enabled = cityNameRadioButton.Checked;
    }

    private void coordsRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        coordsPanel.Enabled = coordsRadioButton.Checked;
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void ShowErrorMessage(string errorMessage)
    {
        if (_errorMessageTimer.Enabled)
        {
            _errorMessageTimer.Stop();
        }
        errorLabel.Text = errorMessage;
        _errorMessageTimer.Tick += (_, _) =>
        {
            errorLabel.Text = string.Empty;
        };
        _errorMessageTimer.Start();
    }

    private void addButton_Click(object sender, EventArgs e)
    {
        if (cityNameRadioButton.Checked)
        {
            if (cityNameTextBox.Text == CityNamePlaceholder)
            {
                ShowErrorMessage(FieldsNotFulledErrorMessage);
                return;
            }

            try
            {
                CityAdded?.Invoke(cityNameTextBox.Text);
            }
            catch (WebException)
            {
                ShowErrorMessage(LocationNotFoundErrorMessage);
            }
        }
        else
        {
            if (latitudeTextBox.Text == LatitudePlaceholder ||
                longitudeTextBox.Text == LongitudePlaceholder ||
                !double.TryParse(latitudeTextBox.Text, out var latitude) ||
                !double.TryParse(longitudeTextBox.Text, out var longitude))
            {
                ShowErrorMessage(FieldsNotFulledErrorMessage);
                return;
            }

            LocationAdded?.Invoke(new Location
            {
                Latitude = latitude,
                Longitude = longitude
            });
        }
    }
}