namespace Calculator.Domain.Mortgages;

public class CompositeLoanCalculator : Mortgate, ILoanCalculator
{
    private readonly ILoanCalculator _publicFundLoanCalculator;
    private readonly ILoanCalculator _businessLoanCalculator;

    public CompositeLoanCalculator(ILoanCalculator publicFundLoanCalculator, ILoanCalculator businessLoanCalculator)
    {
        _publicFundLoanCalculator = publicFundLoanCalculator;
        _businessLoanCalculator = businessLoanCalculator;
    }

    public decimal CalculateEqualPrincipal()
    {
        decimal publicFundMonthlyPayment = _publicFundLoanCalculator.CalculateEqualPrincipal();
        decimal businessMonthlyPayment = _businessLoanCalculator.CalculateEqualPrincipal();
        decimal totalMonthlyPayment = publicFundMonthlyPayment + businessMonthlyPayment;

        return totalMonthlyPayment;
    }

    public decimal CalculateEqualInstallment()
    {
        decimal publicFundMonthlyPayment = _publicFundLoanCalculator.CalculateEqualInstallment();
        decimal businessMonthlyPayment = _businessLoanCalculator.CalculateEqualInstallment();
        decimal totalMonthlyPayment = publicFundMonthlyPayment + businessMonthlyPayment;

        return totalMonthlyPayment;
    }
}
