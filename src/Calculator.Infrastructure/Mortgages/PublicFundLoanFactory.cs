
using Calculator.Domain.Mortgages;

namespace Calculator.Infrastructure.Mortgages;

public class PublicFundLoanFactory : ILoanCalculatorFactory
{
    public ILoanCalculator Create(decimal commercialLoanLoanAmount, decimal commercialInterestRate,
        int commercialLoanTerm, decimal publicFundLoanAmount,
        decimal publicFundInterestRate, int publicFundLoanTerm,
        decimal lpr, decimal spreadRate)
    => new PublicFundLoanCalculator(publicFundLoanAmount, publicFundInterestRate, publicFundLoanTerm);
}
