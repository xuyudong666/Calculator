namespace QuickCalc.Domain.Mortgages;

public interface ILoanCalculator
{
    /// <summary>
    /// 等额本金
    /// </summary>
    /// <returns></returns>
    public string CalculateEqualPrincipal();
    /// <summary>
    /// 等额本息
    /// </summary>
    /// <returns></returns>
    public string CalculateEqualInstallment();
}
