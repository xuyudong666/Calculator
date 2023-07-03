using QuickCalc.App.ViewModels;

namespace QuickCalc.App
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(LabelViewModel labelViewModel)
        {
            InitializeComponent();
            BindingContext = labelViewModel;
        }
    }
}