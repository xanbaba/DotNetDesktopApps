using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PCBuilder.Services;

namespace PCBuilder;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;

        IPcItemsManager pcItemsManager = new PcItemsManager();
        MotherboardSelectionPage = new MotherboardUserControl(pcItemsManager);
    }
    
    public MotherboardUserControl MotherboardSelectionPage { get; }
}