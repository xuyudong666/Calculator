namespace Calculator.Infrastructure;

internal class Multiplier : IComputable
{
    public double Calculate(double num1, double num2)
    {
        return num1 * num2;
    }
}
