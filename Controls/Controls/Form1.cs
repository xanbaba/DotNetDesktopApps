using System;
using System.Linq;
using System.Windows.Forms;

namespace Controls;

public partial class Form1 : Form
{
    private bool _isRestart;
    
    public Form1()
    {
        InitializeComponent();
    }

    private bool CanPlaceOperator()
    {
        return result.Text.Length != 0 && char.IsNumber(result.Text.Last());
    }

    private void NumberClick(object sender, EventArgs e)
    {
        if (sender is not Button numberKey) return;

        if (_isRestart)
        {
            result.Text = numberKey.Text;
            _isRestart = false;
            return;
        }
        result.Text += numberKey.Text;
    }

    private void OperatorClick(object sender, EventArgs e)
    {
        if (sender is not Button operatorKey) return;
        if (CanPlaceOperator())
        {
            result.Text += operatorKey.Text;
            _isRestart = false;
        }
    }

    private void erase_Click(object sender, EventArgs e)
    {
        result.Text = string.Empty;
    }

    private void eraseLast_Click(object sender, EventArgs e)
    {
        if (result.Text.Length == 0) return;
        result.Text = result.Text.Substring(0, result.Text.Length - 1);
        _isRestart = false;
    }

    private void calculate_Click(object sender, EventArgs e)
    {
        var calculator = new Calculator(result.Text);
        try
        {
            result.Text = calculator.Calculate();
            _isRestart = true;
        }
        catch (ArgumentException)
        {
        }
    }

    private void subtract_Click(object sender, EventArgs e)
    {
        if (sender is not Button operatorKey) return;
        if (CanPlaceMinus())
        {
            result.Text += operatorKey.Text;
            _isRestart = false;
        }
        
    }

    private bool CanPlaceMinus()
    {
        if (result.Text.Length == 0)
        {
            return true;
        }
        var last = result.Text.Last();
        return last != (char)Operators.Minus && last != (char)Operators.Plus;
    }

    private void fraction_Click(object sender, EventArgs e)
    {
        if (sender is not Button fractionKey) return;
        if (CanPlaceFraction())
        {
            result.Text += fractionKey.Text;
        }
    }

    private bool CanPlaceFraction()
    {
        if (!CanPlaceOperator())
        {
            return false;
        }

        for (var i = result.Text.Length - 1; i >= 0; i--)
        {
            var symbol = result.Text[i];
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
}