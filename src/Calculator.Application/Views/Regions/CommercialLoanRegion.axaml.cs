using Avalonia.Controls;
using Calculator.Application.ViewModels.Regions;

namespace Calculator.Application.Views.Regions
{
    public partial class CommercialLoanRegion : UserControl
    {
        public CommercialLoanRegion()
        {
            InitializeComponent();
            DataContext = App.Current.Services.GetService(typeof(CommercialLoanRegionViewModel));
        }
    }
}
