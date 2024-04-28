namespace WpfApp1;

public enum Operators
{
    Power = '^',
    Divide = '/',
    Plus = '+',
    Minus = '-',
    Multiply = '*',
    Remainder = '%'
}

public static class OperatorsHelper
{
    private static List<Operators> HighPower { get; } = new() { Operators.Power };

    private static List<Operators> MiddlePower { get; } =
        new() { Operators.Divide, Operators.Multiply, Operators.Remainder };

    private static List<Operators> LowPower { get; } = new() { Operators.Plus, Operators.Minus };

    public static int CompareOperatorsPowers(Operators first, Operators second)
    {
        var isFirstLow = LowPower.Contains(first);
        var isFirstMiddle = MiddlePower.Contains(first);
        var isFirstHigh = HighPower.Contains(first);

        var isSecondLow = LowPower.Contains(second);
        var isSecondMiddle = MiddlePower.Contains(second);
        var isSecondHigh = HighPower.Contains(second);


        if ((isFirstLow && !isSecondLow) ||
            (isFirstMiddle && isSecondHigh) ||
            (isSecondHigh && !isFirstHigh))
        {
            return -1;
        }

        if ((isSecondLow && !isFirstLow) ||
            (isSecondMiddle && isFirstHigh) ||
            (isFirstHigh && !isSecondHigh))
        {
            return 1;
        }

        if ((isFirstLow && isSecondLow) ||
            (isFirstMiddle && isSecondMiddle) ||
            (isFirstHigh && isSecondHigh))
        {
            return 0;
        }

        throw new ArgumentException("Operators are unidentified");
    }
    
    public static bool IsOperator(string value)
    {
        return Enum.IsDefined(typeof(Operators), (int)value[0]);
    }

    public static Operators GetOperator(string @operator)
    {
        /*Power = '^',
        Divide = '/',
        Plus = '+',
        Minus = '-',
        Multiply = '*',
        Remainder = '%'*/

        if (Enum.IsDefined(typeof(Operators), (int)@operator[0]))
        {
            return (Operators)@operator[0];
        }

        throw new ArgumentException("Operator is invalid");
    }
}