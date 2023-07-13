using Calculator.Application.ViewModels.Regions;
using Microsoft.Extensions.DependencyInjection;

namespace Calculator.Application.Services
{
    public static class StartUp
    {
        public static void ConfigureServices(IServiceCollection serviceCollection)
        {


            serviceCollection.AddSingleton<CommercialLoanRegionViewModel>();
        }
    }
}
