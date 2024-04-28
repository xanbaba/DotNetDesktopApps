using System.Text;

namespace WpfApp1;

public static class CalculatorHelper
{
    public static string ReadNumber(string equation, int startIndex, out int endIndex)
        // returns the string representation of a read number
        // endIndex : returns the index of a char in equation which goes after the read number
    {
        var number = new StringBuilder();
        var index = startIndex;

        var add = 0;
        if (equation[startIndex] == (char)Operators.Minus)
        {
            number.Append((char)Operators.Minus);
            add = 1;
        }
        for (var i = startIndex + add; i < equation.Length; i++)
        {
            var symbol = equation[i];
            if (char.IsNumber(symbol) || symbol == '.')
            {
                number.Append(symbol);
                ++index;
            }
            else
            {
                break;
            }
        }

        endIndex = index + add;
        return number.ToString();
    }

    public static bool IsNodeNumber(Node node)
    {
        return node.Value.All(c => char.IsNumber(c) || c == '.' || c == (char)Operators.Minus);
    }
}