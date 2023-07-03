
using Calculator.Domain.Mortgages;

namespace Calculator.Infrastructure.Mortgages;

public class PublicFundLoanFactory : ILoanCalculatorFactory
{
    public ILoanCalculator Create(decimal loanAmount, decimal interestRate, int loanTerm, decimal lpr, decimal spreadRate)
    => new PublicFundLoanCalculator(loanAmount,interestRate,loanTerm);
}
