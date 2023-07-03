namespace Calculator.Infrastructure;

internal class Divider : IComputable
{
    public double Calculate(double num1, double num2)
    {
        if (num2 == 0)
            return 0;
        return num1 / num2;
    }
}
