using System.ComponentModel.DataAnnotations;

namespace Calculator.Application.Models;

public enum InterestRatePattern
{
    [Display(Name = "23年6月20日最新报价利率")]
    CurrentRate,
    
    [Display(Name = "基准利率")]
    BasicRate,
    
    [Display(Name = "基准利率上限（1.1倍）")]
    BasicRateUpLimit110,
    
    [Display(Name = "基准利率上限（1.05倍）")]
    BasicRateUpLimit105,
    
    [Display(Name = "基准利率下限（85折）")]
    BasicRateLowerLimit85,
    
    [Display(Name = "基准利率下限（7折）")]
    BasicRateLowerLimit70
}