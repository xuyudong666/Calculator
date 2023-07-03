using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

using Calculator.Application.ViewModels;
using Calculator.Application.Views;

namespace Calculator.Application;

public partial class App : Avalonia.Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new Dashboard
            {
                DataContext = new DashboardViewModel()
            };
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            singleViewPlatform.MainView = new Dashboard
            {
                DataContext = new DashboardViewModel()
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}
