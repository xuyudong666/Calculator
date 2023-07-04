using System.ComponentModel.DataAnnotations;

namespace Calculator.Application.Models;
public enum LoadTermOfYear
{
    [Display(Name = "半年（6期）")]
    Half=(1/2),
    
    [Display(Name = "1年（12期）")]
    One=1,
    
    [Display(Name = "2年（24期）")]
    Two=2,
    
    [Display(Name = "3年（36期）")]
    Three=3,
    
    [Display(Name = "4年（48期）")]
    Four,
    
    [Display(Name = "5年（60期）")]
    Five,
    
    [Display(Name = "6年（72期）")]
    Six,
    
    [Display(Name = "7年（84期）")]
    Seven,
    
    [Display(Name = "8年（96期）")]
    Eight,
    
    [Display(Name = "9年（108期）")]
    Nine,
    
    [Display(Name = "10年（120期）")]
    Ten,
}