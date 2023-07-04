using Calculator.Domain.Mortgages;

namespace Calculator.Doamin.Tests.Mortgages;

public class BusinessLoanCalculatorTests
{
    [Fact]
    public void CalculateMonthlyPayment_WhenNotZero_ReturnsAmount()
    {
        CommercialLoanCalculator morgate = new(1000000, 4.2m, 20, 4.2m, 0);
        var result = morgate.CalculateEqualInstallment();
        Assert.Equal(6165.71m, result);
    }

    [Fact]
    public void CalculateFirstMonthPayment_WhenNotZero_ReturnsAmount()
    {
        CommercialLoanCalculator morgate = new(1000000, 4.2m, 20, 4.2m, 0);
        var result = morgate.CalculateEqualPrincipal();
        Assert.Equal(7666.67m, result);
    }

    [Fact]
    public void CalculateSubsequentMonthPayment_WhenNotZero_ReturnsAmount()
    {
        CommercialLoanCalculator morgate = new(1000000, 4.2m, 20, 4.2m, 0);
        morgate.CalculateEqualPrincipal();
        var result = morgate.CalculateSubsequentMonthPayment(1);
        Assert.Equal(7652.08m, result);
    }
}