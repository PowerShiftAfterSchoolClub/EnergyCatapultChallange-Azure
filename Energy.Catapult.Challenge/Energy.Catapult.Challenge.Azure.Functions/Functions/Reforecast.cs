using AutoMapper;
using Energy.Captapult.Challenge.DataAccess;
using Energy.Catapult.Challenge.Azure.Functions.Domain.Forecasts;
using Energy.Catapult.Challenge.Azure.Functions.Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Energy.Catapult.Challenge.Azure.Functions.Functions
{
    public class Reforecast
    {
        private readonly dBEnergyCatapultPresumedOpenDataChallangeContext dbClient;
        private readonly IForecaster<ForecastRequest, ForecastResult> pvForecaster;
        private readonly IForecaster<ForecastRequest, ForecastResult> demandForecaster;
        private readonly IMapper mapper;
        private readonly IConfiguration config;

        public Reforecast(
            dBEnergyCatapultPresumedOpenDataChallangeContext dbClient,
            IEnumerable<IForecaster<ForecastRequest, ForecastResult>> forcasters,
            IMapper mapper,
            IConfiguration config)
        {
            // TODO: Don't inject DB into here, better to inject an abstration (but this is quick and dirty)
            this.dbClient = dbClient ?? throw new ArgumentNullException(nameof(dbClient));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this.config = config ?? throw new ArgumentNullException(nameof(config));

            this.pvForecaster = forcasters.Single(f => f.Name == "PV Forecaster");
            this.demandForecaster = forcasters.Single(f => f.Name == "Demand Forecaster");

            this.dbClient.ChangeTracker.AutoDetectChangesEnabled = false;
        }

        [Produces("application/json")]
        [Consumes("application/json")]
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
            var task = Convert.ToInt32(req.Query["task"]);


            if (fromUtc > toUtc)
            {
                throw new ArgumentOutOfRangeException("Stupid to from dates.");
            }

            // Get the weather
            var request = this.GetWeatherForecast(fromUtc, toUtc, task);

            if(request.data.Count == 0)
            {
                return new NotFoundObjectResult("No weather available for the supplied dates and task.");
            }
            try
            {

                // Get next run id
                var nextRunId = this.GetNextRunId(task);

                // Get PV and Demand forecasts from the ML
                var forecast = await this.GetPvAndDemandForecasts(task, request);

                // Construct the output
                var taskOutput = this.buildTaskOutput(forecast, task, nextRunId);

                // Save into the database (need new table for this)
                await this.dbClient._21forecastoutputsByTaskRun.AddRangeAsync(taskOutput);
                var updateCount = await this.dbClient.SaveChangesAsync();

                // Return both to user
                return new OkObjectResult(new
                {
                    DbUpdated = updateCount > 0,
                    weather = request.data,
                    forecast,
                    taskOutput
                });
            }
            catch (Exception ex)
            {
                return new ObjectResult(ex) { StatusCode = 500 };
            }

        }



        private async Task<List<Task0ForecastsPvandDemandRun1>> GetPvAndDemandForecasts(int task, ForecastRequest request)
        {
            // GET Demand Forecast
            var demandForecast = await this.demandForecaster.GetAsync(request);

            // Get PV Forecast
            var pvForecast = await this.pvForecaster.GetAsync(request);

            // Stitch together
            var forecast = new List<Task0ForecastsPvandDemandRun1>();

            for (int i = 0; i < request.data.Count; i++)
            {
                forecast.Add(new Task0ForecastsPvandDemandRun1()
                {
                    DateTimeUtc = DateTime.Parse(request.data[i].dateTimeUTC),
                    Task0ForecsatPv = pvForecast.result[i],
                    Task0ForecastDemandMw = demandForecast.result[i],
                    TaskName = ""
                });
            }

            return forecast;
        }

        private ForecastRequest GetWeatherForecast(DateTime fromUtc, DateTime toUtc, int task)
        {
            // TODO: Move this into a DAL and inject

            // Get the weather forecast for the supplied dates
            var weatherForecast = dbClient._10forecastinputsByTask
                .Where(w => w.DateTimeUtc >= fromUtc && w.DateTimeUtc <= toUtc && w.Task == task)
                .ToList();

            // Map to the right format for the ML API
            var request = new ForecastRequest()
            {
                data = this.mapper.Map<List<ForecastRequestItem>>(weatherForecast)
            };

            return request;
        }

        private int GetNextRunId(int task)
        {
            // TODO: Move this into a DAL and inject

            var lastRun = dbClient._21forecastoutputsByTaskRun
                .Where(r => r.Task == task)
                .Max(r => r.RunId);

            return lastRun.HasValue ? lastRun.Value + 1 : 1;
        }

        private List<_21forecastoutputsByTaskRun> buildTaskOutput(List<Task0ForecastsPvandDemandRun1> forecast, int task, int run)
        {
            var pvName = this.config["PvModelName"];
            var pvUrl = this.config["PvForecastUri"];

            var demandName = this.config["DemandModelName"];
            var demandUrl = this.config["DemandForecastUri"];

            var timestamp = DateTime.Now;

            var output = forecast.Select(f => new _21forecastoutputsByTaskRun()
            {
                DateTimeUtc = f.DateTimeUtc,
                ForecastDemandMw = f.Task0ForecastDemandMw,
                ForecastPv = f.Task0ForecsatPv,
                TaskName = $"Task{task}",
                Task = task,
                RunId = run,
                RunTimeStamp = timestamp,
                PvforecastModelName = pvName,
                DemandForecastModelName = demandName,
                PvmodelGuid = this.ExtractGuid(pvUrl),
                DemandModelGuid = this.ExtractGuid(demandUrl)
            }) ;

            return output.ToList();
        }

        private string ExtractGuid(string input)
        {
            var match = Regex.Match(input, @"[{(]?[0-9a-f]{8}[-]?([0-9a-f]{4}[-]?){3}[0-9a-f]{12}[)}]?");

            return string.IsNullOrWhiteSpace(match.Value) ? "Do not know" : match.Value;
        }
    }
}
