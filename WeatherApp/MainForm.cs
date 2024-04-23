using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WeatherApp;

public partial class MainForm : Form
{
    public static event Action<WeatherLocation>? WeatherRequested;

    private readonly WeathersManager _weathersManager = new();

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        weatherLocationsCheckListBox.DataSource = _weathersManager.GetBindingList();
    }

    private void addButton_Click(object sender, EventArgs e)
    {
        var addWeatherForm = new AddWeatherLocationForm();
        addWeatherForm.ShowDialog();
    }

    private void removeButton_Click(object sender, EventArgs e)
    {
        foreach (int a in weatherLocationsCheckListBox.CheckedIndices)
        {
            Console.WriteLine(a);
        }

        _weathersManager.RemoveWeatherLocations(weatherLocationsCheckListBox.CheckedIndices);
    }

    private void refreshButton_Click(object sender, EventArgs e)
    {
        _weathersManager.RefreshWeatherLocations(weatherLocationsCheckListBox.CheckedIndices);
    }

    private void moreButton_Click(object sender, EventArgs e)
    {
        var weatherInfoForm = new WeatherInfoForm();
        WeatherRequested?.Invoke(
            _weathersManager.GetWeatherLocation(weatherLocationsCheckListBox.SelectedIndex));
        weatherInfoForm.ShowDialog();
    }

    private void importButton_Click(object sender, EventArgs e)
    {
        var dialog = new OpenFileDialog();
        dialog.Filter = @"wthr files (*.wthr)|*.wthr";
        dialog.ShowDialog();
        if (string.IsNullOrWhiteSpace(dialog.FileName))
        {
            return;
        }

        try
        {
            var weatherLocation = JsonConvert.DeserializeObject<WeatherLocation>(File.ReadAllText(dialog.FileName));
            if (weatherLocation == null) throw new Exception();
            _weathersManager.ImportWeatherLocation(weatherLocation);
            MessageBox.Show(@"The weather was successfully imported");
        }
        catch (Exception)
        {
            MessageBox.Show(@"An Error occured while importing the weather");
        }
    }
}