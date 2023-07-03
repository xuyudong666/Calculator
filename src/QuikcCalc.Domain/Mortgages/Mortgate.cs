
namespace QuickCalc.Domain.Mortgages;

public class Mortgate
{
    protected Mortgate()
    {
        
    }

    internal Mortgate(decimal loanAmount, decimal interestRate, int loanTerm)
    {
        LoanAmount = loanAmount;
        InterestRate = interestRate;
        LoanTerm = loanTerm;
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
}
