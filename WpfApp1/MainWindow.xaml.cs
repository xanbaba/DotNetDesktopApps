using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace WpfApp1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow
{
    private bool _isRestart;
    
    public MainWindow()
    {
        InitializeComponent();
    }

    private void NumberButtonClick(object sender, RoutedEventArgs e)
    {
        if (sender is not Button numberKey) return;

        if (_isRestart)
        {
            Equation.Text = numberKey.Content.ToString();
            _isRestart = false;
            return;
        }
        Equation.Text += numberKey.Content.ToString();
    }
    
    private bool CanPlaceOperator()
    {
        return Equation.Text.Length != 0 && char.IsNumber(Equation.Text.Last());
    }

    private void OperatorClick(object sender, RoutedEventArgs e)
    {
        if (sender is not Button operatorKey) return;
        if (CanPlaceOperator())
        {
            Equation.Text += operatorKey.Content.ToString();
            _isRestart = false;
        }
    }

    private void EraseClick(object sender, RoutedEventArgs e)
    {
        Equation.Text = string.Empty;
        Result.Text = string.Empty;
    }

    private void EraseLastClick(object sender, RoutedEventArgs e)
    {
        if (Equation.Text.Length == 0) return;
        Equation.Text = Equation.Text.Substring(0, Equation.Text.Length - 1);
        _isRestart = false;
    }

    private void CalculateClick(object sender, RoutedEventArgs e)
    {
        var calculator = new Calculator(Equation.Text);
        try
        {
            Result.Text = calculator.Calculate();
            Equation.Text = Result.Text;
            _isRestart = true;
        }
        catch (ArgumentException)
        {
        }
    }

    private void SubtractClick(object sender, RoutedEventArgs e)
    {
        if (sender is not Button operatorKey) return;
        if (CanPlaceMinus())
        {
            Equation.Text += operatorKey.Content.ToString();
            _isRestart = false;
        }
        
    }

    private bool CanPlaceMinus()
    {
        if (Equation.Text.Length == 0)
        {
            return true;
        }
        var last = Equation.Text.Last();
        return last != (char)Operators.Minus && last != (char)Operators.Plus;
    }

    private void FractionClick(object sender, RoutedEventArgs e)
    {
        if (sender is not Button fractionKey) return;
        if (CanPlaceFraction())
        {
            Equation.Text += fractionKey.Content.ToString();
        }
    }

    private bool CanPlaceFraction()
    {
        if (!CanPlaceOperator())
        {
            return false;
        }

        for (var i = Equation.Text.Length - 1; i >= 0; i--)
        {
            var symbol = Equation.Text[i];
            if (OperatorsHelper.IsOperator(symbol.ToString()))
            {
                break;
            }

            if (symbol == '.')
            {
                return false;
            }
        }

        return true;
    }

    private void MainWindow_OnKeyDown(object sender, KeyEventArgs e)
    {
        var keyString = e.Key.ToString();
        Console.WriteLine(e.Key);
        switch (keyString)
        {
            case "NumPad0":
            case "D0":
                NumberZeroButton.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                break;
            case "NumPad1":
            case "D1":
                NumberOneButton.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                break;
            case "NumPad2":
            case "D2":
                NumberTwoButton.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                break;
            case "NumPad3":
            case "D3":
                NumberThreeButton.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                break;
            case "NumPad4":
            case "D4":
                NumberFourButton.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                break;
            case "NumPad5":
            case "D5":
                NumberFiveButton.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                break;
            case "NumPad6":
            case "D6":
                NumberSixButton.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                break;
            case "NumPad7":
            case "D7":
                NumberSevenButton.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                break;
            case "NumPad8":
            case "D8":
                NumberEightButton.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                break;
            case "NumPad9":
            case "D9":
                NumberNineButton.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                break;
            case "Multiply":
                MultiplyButton.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                break;
            case "Subtract":
                SubtractButton.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                break;
            case "Divide":
                DivideButton.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                break;
            case "Add":
                AddButton.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                break;
            case "OemPeriod":
                FractionButton.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                break;
            case "Back":
                BackButton.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                break;
        }
    }
}