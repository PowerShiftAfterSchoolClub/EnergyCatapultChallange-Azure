using Energy.Catapult.Challenge.Azure.Functions.Domain.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Energy.Catapult.Challenge.Azure.Functions.Domain.Forecasts
{
    class PvForecaster : IForecaster<ForecastRequest, ForecastResult>
    {
        private readonly HttpClient http;
        private readonly IConfiguration config;

        public PvForecaster(HttpClient http, IConfiguration config)
        {
            this.http = http ?? throw new ArgumentNullException(nameof(http));
            this.config = config ?? throw new ArgumentNullException(nameof(config));
        }

        public string Name => "PV Forecaster";

        public async Task<ForecastResult> GetAsync(ForecastRequest request)
        {
            string modelUrl = this.config["PvForecastUri"];

            var response = await this.http.PostAsJsonAsync(modelUrl, request);

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            // Deserialise - the JSON we're getting back is a mess: unescape and drop first and last elements.
            var forecast = JsonSerializer.Deserialize<ForecastResult>(Regex.Unescape(responseString)[1..^1]);

            return forecast;
        }
    }
}
