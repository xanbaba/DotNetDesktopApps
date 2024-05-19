using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using PCBuilder.Model;
using PCBuilder.Services;

namespace PCBuilder;

public sealed partial class MotherboardUserControl : INotifyPropertyChanged
{
    private const string MotherboardsFilePath = "Source/Motherboards.json";
    
    private int _priceRangeTill;
    private readonly int _priceRangeMin;
    private readonly int _priceRangeMax;

    public MotherboardUserControl(IPcItemsManager pcItemsManager)
    {
        InitializeComponent();
        DataContext = this;

        Motherboards = new ObservableCollection<Motherboard>(pcItemsManager.GetPcItems<Motherboard>(MotherboardsFilePath));
        Manufacturers = new ObservableCollection<CheckableOption>(Motherboards.Select<Motherboard, CheckableOption>(motherboard => new CheckableOption
        {
            Name = motherboard.Manufacturer,
            IsChecked = false
        }).DistinctBy<CheckableOption, string>(c => c.Name ?? string.Empty));
        MotherboardTypes = new ObservableCollection<CheckableOption>(Motherboards.Select<Motherboard, CheckableOption>(motherboard => new CheckableOption
        {
            Name = motherboard.Type,
            IsChecked = false
        }).DistinctBy<CheckableOption, string>(c => c.Name ?? string.Empty));

        var minPrice = Motherboards.MinBy(motherboard => motherboard.Price);

        if (minPrice != null)
        {
            PriceRangeMin = minPrice.Price;
        }
        
        var maxPrice = Motherboards.MaxBy(motherboard => motherboard.Price);

        if (maxPrice != null)
        {
            PriceRangeMax = maxPrice.Price;
        }

        PriceRangeTill = PriceRangeMax;
    }

    public ObservableCollection<Motherboard> Motherboards { get; }
    public ObservableCollection<CheckableOption> Manufacturers { get; }
    public ObservableCollection<CheckableOption> MotherboardTypes { get; }

    public int PriceRangeTill
    {
        get => _priceRangeTill;
        set => SetField(ref _priceRangeTill, value);
    }

    public int PriceRangeMin
    {
        get => _priceRangeMin;
        private init => SetField(ref _priceRangeMin, value);
    }

    public int PriceRangeMax
    {
        get => _priceRangeMax;
        private init => SetField(ref _priceRangeMax, value);
    }

    #region INotifyPropertyChangedImplementation

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private void SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return;
        field = value;
        OnPropertyChanged(propertyName);
    }

    #endregion
}