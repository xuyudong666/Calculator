using Calculator.Domain.Mortgages;

namespace Calculator.Infrastructure.Mortgages;

public class CompositeLoanFactory : ILoanCalculatorFactory
{
    public ILoanCalculator Create(decimal commercialLoanLoanAmount, decimal commercialInterestRate, int commercialLoanTerm, decimal publicFundLoanAmount, decimal publicFundInterestRate, int publicFundLoanTerm, decimal lpr, decimal spreadRate)
    {
        ILoanCalculator commercialLoanCalculator = new CommercialLoanCalculator(commercialLoanLoanAmount, commercialInterestRate, commercialLoanTerm, lpr, spreadRate);
        ILoanCalculator publicFundLoanCalculator = new PublicFundLoanCalculator(publicFundLoanAmount, publicFundInterestRate, publicFundLoanTerm);
        return new CompositeLoanCalculator(publicFundLoanCalculator, commercialLoanCalculator);
    }
}
