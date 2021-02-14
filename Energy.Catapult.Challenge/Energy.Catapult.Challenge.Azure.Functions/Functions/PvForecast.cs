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
using System.Net;

namespace Energy.Catapult.Challenge.Azure.Functions.Functions
{
    public class PvForecast
    {
        private readonly IForecaster<ForecastRequest, ForecastResult> forecaster;

        public PvForecast(IForecaster<ForecastRequest, ForecastResult> forecaster)
        {
            this.forecaster = forecaster ?? throw new System.ArgumentNullException(nameof(forecaster));
        }

        /// <summary>
        /// Generates a forecast from ML model and saves to datastore.
        /// </summary>
        /// <remarks>
        /// Sample Request
        /// 
        /// POST /PvForecast
        /// {
        ///   "data": [
        ///     {
        ///       "dateTimeUTC": "2018-07-22 12:00:00.0000000",
        ///       "temp_location3": 19.7,
        ///       "temp_location6": 23.056,
        ///       "temp_location2": 24.73,
        ///       "temp_location4": 19.88,
        ///       "temp_location5": 22.14,
        ///       "temp_location1": 22.14,
        ///       "solar_location3": 831,
        ///       "solar_location6": 865,
        ///       "solar_location2": 861,
        ///       "solar_location4": 832,
        ///       "solar_location5": 863,
        ///       "solar_location1": 858,
        ///       "summerWinter": "SUMMER",
        ///       "dateTimeLocal": "2018-07-22 12:00:00.0000000",
        ///       "year": 2018,
        ///       "monthNum": 7,
        ///       "monthName": "Jul",
        ///       "weekNumber": 30,
        ///       "dayOfWeek": "Sun",
        ///       "dayOfWeekNumber": 1,
        ///       "hourText": 12,
        ///       "hourNumber": 12,
        ///       "settlementPeriod": 25,
        ///       "bankHoliday": "",
        ///       "workingDay": ""
        ///     },
        ///      {
        ///       "dateTimeUTC": "2018-07-22 12:30:00.0000000",
        ///       "temp_location3": 19.7,
        ///       "temp_location6": 23.056,
        ///       "temp_location2": 24.73,
        ///       "temp_location4": 19.88,
        ///       "temp_location5": 22.14,
        ///       "temp_location1": 22.14,
        ///       "solar_location3": 22,
        ///       "solar_location6": 865,
        ///       "solar_location2": 861,
        ///       "solar_location4": 832,
        ///       "solar_location5": 863,
        ///       "solar_location1": 858,
        ///       "summerWinter": "SUMMER",
        ///       "dateTimeLocal": "2018-07-22 12:30:00.0000000",
        ///       "year": 2018,
        ///       "monthNum": 7,
        ///       "monthName": "Jul",
        ///       "weekNumber": 30,
        ///       "dayOfWeek": "Sun",
        ///       "dayOfWeekNumber": 1,
        ///       "hourText": 12,
        ///       "hourNumber": 12,
        ///       "settlementPeriod": 25,
        ///       "bankHoliday": "",
        ///       "workingDay": ""
        ///     }
        ///   ]
        /// }
        /// 
        /// </remarks>
        /// <param name="req">Forecast Request</param>
        /// <param name="log">Logger</param>
        /// <returns>Generated forecast</returns>
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<ForecastPeriod>))]
        [Produces("application/json")]
        [Consumes("application/json")]
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

            var pvRequest = JsonSerializer.Deserialize<ForecastRequest>(requestBody);

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
