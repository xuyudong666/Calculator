using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using Calculator.Application.Services;
using Calculator.Application.ViewModels;
using Calculator.Application.Views;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Calculator.Application;

public partial class App : Avalonia.Application
{
    public new static App Current => (App)Avalonia.Application.Current!;

    public IServiceProvider Services { get; private set; }

    public override void Initialize()
    {
        Services = ConfigureServices();

        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        // Line below is needed to remove Avalonia data validation.
        // Without this line you will get duplicate validations from both Avalonia and CT
        BindingPlugins.DataValidators.RemoveAt(0);

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

    private static IServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();

        StartUp.ConfigureServices(services);

        return services.BuildServiceProvider();
    }
}
