namespace Calculator.Domain.Mortgages;

/// <summary>
/// 商业贷款
/// </summary>
public class CommercialLoanCalculator : ILoanCalculator
{
    public CommercialLoanCalculator(decimal loanAmount, decimal interestRate, int loanTerm, decimal lpr, decimal spreadRate)
    {
        LoanAmount = loanAmount;
        InterestRate = interestRate;
        LoanTerm = loanTerm;
        Lpr = lpr;
        SpreadRate = spreadRate;
    }

    /// <summary>
    /// 贷款本金 单位:万 人民币
    /// </summary>
    public decimal LoanAmount { get; set; }
    /// <summary>
    /// 贷款利率
    /// </summary>
    public decimal InterestRate { get; set; }
    /// <summary>
    /// 贷款期限(年)
    /// </summary>
    public int LoanTerm { get; set; }
    /// <summary>
    /// LPR
    /// </summary>
    public decimal Lpr { get; set; }
    /// <summary>
    /// 基点利率
    /// </summary>
    public decimal SpreadRate { get; set; }

    /// <summary>
    /// 计算LPR+基点利率模式下的贷款利率
    /// </summary>
    /// <returns></returns>
    private decimal CalculateInterestRate()
    {
        return Lpr + SpreadRate;
    }


    /// <summary>
    /// 等额本息还款方式计算每月还款额
    /// </summary>
    /// <returns></returns>
    public decimal CalculateEqualInstallment()
    {
        // 还款期数
        int numberOfPayments = LoanTerm * 12;
        // 月利率
        decimal monthlyInterestRate = CalculateInterestRate() / 12 / 100;

        decimal numerator = LoanAmount * monthlyInterestRate * (decimal)Math.Pow(1 + (double)monthlyInterestRate, numberOfPayments);
        decimal denominator = (decimal)Math.Pow(1 + (double)monthlyInterestRate, numberOfPayments) - 1;

        decimal monthlyPayment = numerator / denominator;
        return monthlyPayment;
    }

    /// <summary>
    /// 等额本金还款方式计算首月还款金额
    /// </summary>
    /// <returns></returns>
    public decimal CalculateEqualPrincipal()
    {
        // 还款期数
        int numberOfPayments = LoanTerm * 12;
        // 月利率
        decimal monthlyInterestRate = CalculateInterestRate() / 12 / 100;

        decimal firstMonthPayment = LoanAmount / numberOfPayments + LoanAmount * monthlyInterestRate;
        return firstMonthPayment;
    }

    /// <summary>
    /// 等额本金还款方式计算后续每月还款金额
    /// </summary>
    /// <param name="month"></param>
    /// <returns></returns>
    public decimal CalculateSubsequentMonthPayment(int month)
    {
        // 还款期数
        int numberOfPayments = LoanTerm * 12;
        // 月利率
        decimal monthlyInterestRate = CalculateInterestRate() / 12 / 100;

        decimal subsequentMonthPayment = LoanAmount / numberOfPayments +
            (LoanAmount - month * (LoanAmount / numberOfPayments)) * monthlyInterestRate;
        return subsequentMonthPayment;
    }
}
