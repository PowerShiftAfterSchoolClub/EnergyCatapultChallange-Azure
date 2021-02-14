using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Energy.Captapult.Challenge.DataAccess;
using System.Linq;
using AutoMapper;
using Energy.Catapult.Challenge.Azure.Functions.Domain.Model;
using System.Collections.Generic;
using Energy.Catapult.Challenge.Azure.Functions.Domain.Forecasts;

namespace Energy.Catapult.Challenge.Azure.Functions.Functions
{
    public class Reforecast
    {
        private readonly dBEnergyCatapultPresumedOpenDataChallangeContext dbClient;
        private readonly IForecaster<ForecastRequest, ForecastResult> pvForecaster;
        private readonly IForecaster<ForecastRequest, ForecastResult> demandForecaster;
        private readonly IMapper mapper;

        public Reforecast(
            dBEnergyCatapultPresumedOpenDataChallangeContext dbClient,
            IEnumerable<IForecaster<ForecastRequest, ForecastResult>> forcasters,
            IMapper mapper)
        {
            // TODO: Don't inject DB into here, better to inject an abstration (but this is quick and dirty)
            this.dbClient = dbClient ?? throw new ArgumentNullException(nameof(dbClient));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

            this.pvForecaster = forcasters.Single(f => f.Name == "PV Forecaster");
            this.demandForecaster = forcasters.Single(f => f.Name == "Demand Forecaster");

            this.dbClient.ChangeTracker.AutoDetectChangesEnabled = false;
        }

        [FunctionName("Reforecast")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
          
            ILogger log)
        {
            if (req is null)
            {
                throw new ArgumentNullException(nameof(req));
            }

            if (log is null)
            {
                throw new ArgumentNullException(nameof(log));
            }

            var fromUtc = DateTime.Parse(req.Query["fromUtc"]);
            var toUtc = DateTime.Parse(req.Query["toUtc"]);
            var task = req.Query["task"];


            if (fromUtc > toUtc)
            {
                throw new ArgumentOutOfRangeException("Stupid to from dates.");
            }

            // Get the weather
            var request = this.GetWeatherForecast(fromUtc, toUtc);

            // Get PV and Demand forecasts from the ML
            var forecast = await this.GetPvAndDemandForecasts(task, request);

            // Save into the database
           
            this.dbClient.Task0ForecastsPvandDemandRun1s.UpdateRange(forecast);
            
            this.dbClient.SaveChanges();

            // Return both to user
            return new OkObjectResult(new
            {
                weather = request.data,
                forecast
            });
        }

        private async Task<List<Task0ForecastsPvandDemandRun1>> GetPvAndDemandForecasts(Microsoft.Extensions.Primitives.StringValues task, ForecastRequest request)
        {
            // Get PV Forecast
            var pvForecast = await this.pvForecaster.GetAsync(request);

            // GET Demand Forecast
            var demandForecast = await this.demandForecaster.GetAsync(request);

            // Stitch together
            var forecast = new List<Task0ForecastsPvandDemandRun1>();

            for (int i = 0; i < request.data.Count; i++)
            {
                forecast.Add(new Task0ForecastsPvandDemandRun1()
                {
                    DateTimeUtc = DateTime.Parse(request.data[i].dateTimeUTC),
                    Task0ForecsatPv = pvForecast.result[i],
                    Task0ForecastDemandMw = demandForecast.result[i],
                    TaskName = task
                });
            }

            return forecast;
        }

        private ForecastRequest GetWeatherForecast(DateTime fromUtc, DateTime toUtc)
        {
            // Get the weather forecast for the supplied dates
            var weatherForecast = dbClient.Task0ForecastCalendarMapWithForecastWeatherHhs
                .Where(w => w.DateTimeUtc >= fromUtc && w.DateTimeUtc <= toUtc)
                .ToList();

            // Map to the right format for the ML API
            var request = new ForecastRequest()
            {
                data = this.mapper.Map<List<ForecastRequestItem>>(weatherForecast)
            };

            return request;
        }
    }
}