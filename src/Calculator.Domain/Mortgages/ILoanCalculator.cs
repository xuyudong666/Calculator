namespace Calculator.Domain.Mortgages;

public interface ILoanCalculator
{
    /// <summary>
    /// 等额本金
    /// </summary>
    /// <returns></returns>
    public decimal CalculateEqualPrincipal();
    /// <summary>
    /// 等额本息
    /// </summary>
    /// <returns></returns>
    public decimal CalculateEqualInstallment();
}
