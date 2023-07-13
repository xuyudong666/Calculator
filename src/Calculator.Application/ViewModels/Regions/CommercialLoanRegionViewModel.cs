using Calculator.Application.Extensions;
using Calculator.Application.Models;
using Calculator.Application.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;

namespace Calculator.Application.ViewModels.Regions
{
    public partial class CommercialLoanRegionViewModel : ObservableObject
    {
        [ObservableProperty]
        private decimal _amount;

        [ObservableProperty]
        private EnumMember<LoadTermOfYear>? _selectedLoadTermOfYear;

        [ObservableProperty]
        private EnumMember<InterestRatePattern>? _selectedInterestRatePattern;

        [ObservableProperty]
        private decimal _interestRate;

        [ObservableProperty]
        private int _basePoint;

        [ObservableProperty]
        private decimal _commercialRate;

        [ObservableProperty]
        private RepaymentScheme _repaymentScheme;

        public CommercialLoanRegionViewModel(DemoService demoService)
        {
            var a = demoService.Get();
        }

        public static string Title => CalculatorNames.CommercialLoanCalculator;

        public IReadOnlyCollection<EnumMember<LoadTermOfYear>> LoadTermOfYearOps { get; private set; }
            = EnumMember<LoadTermOfYear>.GetMembers();

        public IReadOnlyCollection<EnumMember<InterestRatePattern>> InterestRatePatternOps { get; private set; }
            = EnumMember<InterestRatePattern>.GetMembers();
    }
}