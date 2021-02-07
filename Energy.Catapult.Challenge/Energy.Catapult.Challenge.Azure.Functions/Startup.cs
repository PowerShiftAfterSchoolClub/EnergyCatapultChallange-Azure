using Energy.Catapult.Challenge.Azure.Functions.Domain.Forecasts;
using Energy.Catapult.Challenge.Azure.Functions.Domain.Model;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using AzureFunctions.Extensions.Swashbuckle;


[assembly: FunctionsStartup(typeof(Energy.Catapult.Challenge.Azure.Functions.Startup))]


namespace Energy.Catapult.Challenge.Azure.Functions
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddHttpClient();
            //builder.Services.AddSingleton<IServiceCollection>(builder.Services);
            builder.Services.AddTransient<IForecaster<PvForecastRequest, ForecastResult>, PvForecaster>();

            // Add swagger support
            builder.AddSwashBuckle(Assembly.GetExecutingAssembly());
        }
    }
}
