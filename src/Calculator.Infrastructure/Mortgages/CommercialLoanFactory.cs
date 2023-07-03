using Calculator.Domain.Mortgages;

namespace Calculator.Infrastructure.Mortgages;

public class CommercialLoanFactory : ILoanCalculatorFactory
{
    public ILoanCalculator Create(decimal commercialLoanLoanAmount, decimal commercialInterestRate, int commercialLoanTerm, decimal publicFundLoanAmount, decimal publicFundInterestRate, int publicFundLoanTerm, decimal lpr, decimal spreadRate)
    => new CommercialLoanCalculator(commercialLoanLoanAmount, commercialInterestRate, commercialLoanTerm, lpr, spreadRate);
}
