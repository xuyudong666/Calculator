namespace Calculator.Domain.Mortgages;

public interface ILoanCalculatorFactory
{
    public ILoanCalculator Create(decimal commercialLoanLoanAmount, decimal commercialInterestRate, 
        int commercialLoanTerm, decimal publicFundLoanAmount,
        decimal publicFundInterestRate, int publicFundLoanTerm,
        decimal lpr, decimal spreadRate);
}
