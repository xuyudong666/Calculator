
namespace Calculator.Domain.Mortgages;

public class PublicFundLoanCalculator : Mortgate, ILoanCalculator
{
    public PublicFundLoanCalculator(decimal loanAmount, decimal interestRate, int loanTerm) : base(loanAmount, interestRate, loanTerm)
    {
    }

    public decimal CalculateEqualPrincipal()
    {
        decimal monthlyInterestRate = InterestRate / 12 / 100;
        decimal monthlyPayment = LoanAmount / LoanTerm;
        decimal totalInterest = 0;

        for (int i = 0; i < LoanTerm; i++)
        {
            decimal interest = LoanAmount * monthlyInterestRate;
            totalInterest += interest;
            LoanAmount -= monthlyPayment;
        }

        decimal totalPayment = LoanAmount + totalInterest;
        decimal monthlyPaymentWithInterest = totalPayment / LoanTerm;

        return monthlyPaymentWithInterest;
    }

    public decimal CalculateEqualInstallment()
    {
        decimal monthlyInterestRate = InterestRate / 12 / 100;
        decimal monthlyPayment = (LoanAmount * monthlyInterestRate * (decimal)Math.Pow(1 + (double)monthlyInterestRate, LoanTerm)) / ((decimal)Math.Pow(1 + (double)monthlyInterestRate, LoanTerm) - 1);

        return monthlyPayment;
    }
}
