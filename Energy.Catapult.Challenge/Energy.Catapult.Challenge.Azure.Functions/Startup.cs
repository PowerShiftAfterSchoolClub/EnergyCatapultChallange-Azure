using Energy.Catapult.Challenge.Azure.Functions.Domain.Forecasts;
using Energy.Catapult.Challenge.Azure.Functions.Domain.Model;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using AzureFunctions.Extensions.Swashbuckle;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using Energy.Captapult.Challenge.DataAccess;
using AutoMapper;
using Energy.Catapult.Challenge.Azure.Functions.Mappers;

[assembly: FunctionsStartup(typeof(Energy.Catapult.Challenge.Azure.Functions.Startup))]


namespace Energy.Catapult.Challenge.Azure.Functions
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {

            var configuration = builder.GetContext().Configuration;

            builder.Services.AddHttpClient();
            //builder.Services.AddSingleton<IServiceCollection>(builder.Services);
            builder.Services.AddTransient<IForecaster<ForecastRequest, ForecastResult>, PvForecaster>();
            builder.Services.AddTransient<IForecaster<ForecastRequest, ForecastResult>, DemandForecaster>();

            // Add swagger support
            builder.AddSwashBuckle(Assembly.GetExecutingAssembly());

            // Add the db context
            builder.Services.AddDbContext<dBEnergyCatapultPresumedOpenDataChallangeContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetSection("ConnectionStrings")["DefaultConnection"]);
            });

            // Add the mappers
            builder.Services.AddAutoMapper(typeof(WeatherForecastProfile));
        }
    }
}
