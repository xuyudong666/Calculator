namespace Calculator.Infrastructure;

public class Subtractor : IComputable
{
    public double Calculate(double num1, double num2)
    {
        return num1 - num2;
    }
}
