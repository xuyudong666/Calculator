using System.ComponentModel.DataAnnotations;

namespace Calculator.Application.Models;

public enum RepaymentScheme
{
    [Display(Name = "等额本息")]
    EqualInstallment,
    
    [Display(Name = "等额本金")]
    EqualPrincipal
}