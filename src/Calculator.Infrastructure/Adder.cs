namespace Calculator.Infrastructure;

public class Adder : IComputable
{
    public double Calculate(double num1, double num2)
    {
        return num1 + num2;
    }
}