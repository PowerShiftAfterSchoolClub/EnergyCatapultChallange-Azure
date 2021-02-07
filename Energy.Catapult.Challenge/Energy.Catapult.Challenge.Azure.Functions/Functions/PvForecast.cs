using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Energy.Catapult.Challenge.Azure.Functions.Domain.Forecasts;
using Energy.Catapult.Challenge.Azure.Functions.Domain.Model;
using System.IO;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Energy.Catapult.Challenge.Azure.Functions.Functions
{
    public class PvForecast
    {
        private readonly IForecaster<PvForecastRequest, ForecastResult> forecaster;

        public PvForecast(IForecaster<PvForecastRequest, ForecastResult> forecaster)
        {
            this.forecaster = forecaster ?? throw new System.ArgumentNullException(nameof(forecaster));
        }

        [FunctionName("PvForecast")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "POST", Route = null)] HttpRequest req,
            ILogger log)
        {
            // Get the request body
            string requestBody = string.Empty;
            using (var streamReader = new StreamReader(req.Body))
            {
                requestBody = await streamReader.ReadToEndAsync();
            }

            var pvRequest = JsonSerializer.Deserialize<PvForecastRequest>(requestBody);

            // Call the forecaster
            var rawForecast = await this.forecaster.GetAsync(pvRequest);

            // Add times
            var forecasts = new List<ForecastPeriod>();

            foreach (var (First, Second) in rawForecast.result.Zip(pvRequest.data.Select(d =>d.dateTimeUTC)))
            {
                forecasts.Add(new ForecastPeriod { dataTimeUtc = Second, value = First });
            }

            // TODO: Save this forcast back to the DB

            return new OkObjectResult(forecasts);
        }
    }

}
