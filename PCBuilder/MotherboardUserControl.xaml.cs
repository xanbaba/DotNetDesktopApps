using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace PCBuilder;

public partial class MotherboardUserControl : UserControl
{
    public MotherboardUserControl()
    {
        InitializeComponent();
        DataContext = this;
    }

    public ObservableCollection<CheckableOption> Manufacturers { get; set; } = [];
}

public class CheckableOption
{
    public string? Name { get; set; }
    public bool IsChecked { get; set; }
}