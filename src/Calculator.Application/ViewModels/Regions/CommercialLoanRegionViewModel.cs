using System.Collections.Generic;
using System.Linq;
using Calculator.Application.Entensions;
using ReactiveUI;
using Calculator.Application.Models;

namespace Calculator.Application.ViewModels.Regions
{
    internal class CommercialLoanRegionViewModel : ReactiveObject
    {
        private decimal _amount;
        private EnumMember<LoadTermOfYear> _loadTermOfYear;
        private InterestRatePattern _interestRatePattern;
        private decimal _interestRate;
        private int _basePoint;
        private decimal _commercialRate;
        private RepaymentScheme _repaymentScheme;

        public CommercialLoanRegionViewModel()
        {
            _amount = 100; //default
            _loadTermOfYear = LoadTermOfYearOps.First();
        }
        
        public decimal Amount
        {
            get => _amount;
            set => this.RaiseAndSetIfChanged(ref _amount, value);
        }

        public EnumMember<LoadTermOfYear> SelectedLoadTermOfYear
        {
            get => _loadTermOfYear;
            set => this.RaiseAndSetIfChanged(ref _loadTermOfYear, value);
        }

        public IReadOnlyCollection<EnumMember<LoadTermOfYear>> LoadTermOfYearOps { get; private set; }
            = EnumMember<LoadTermOfYear>.GetMembers();

        public InterestRatePattern SelectedInterestRatePattern
        {
            get => _interestRatePattern;
            set => this.RaiseAndSetIfChanged(ref _interestRatePattern, value);
        }

        public decimal InterestRate
        {
            get => _interestRate;
            set => this.RaiseAndSetIfChanged(ref _interestRate, value);
        }

        public int BasePoint
        {
            get => _basePoint;
            set => this.RaiseAndSetIfChanged(ref _basePoint, value); 
        }

        public decimal CommercialRate
        {
            get => _commercialRate;
            set => this.RaiseAndSetIfChanged(ref _commercialRate, value); 
        }

        public RepaymentScheme SelectedRepaymentScheme
        {
            get => _repaymentScheme;
            set => this.RaiseAndSetIfChanged(ref _repaymentScheme, value); 
        }
    }
}
