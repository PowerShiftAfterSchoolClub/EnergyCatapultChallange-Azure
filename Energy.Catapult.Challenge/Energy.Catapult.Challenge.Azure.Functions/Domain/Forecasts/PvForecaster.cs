using Energy.Catapult.Challenge.Azure.Functions.Domain.Model;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Energy.Catapult.Challenge.Azure.Functions.Domain.Forecasts
{
    class PvForecaster : IForecaster<PvForecastRequest, ForecastResult>
    {
        private readonly HttpClient http;

        public PvForecaster(HttpClient http)
        {
            this.http = http ?? throw new ArgumentNullException(nameof(http));
        }

        public string Name => "PV Forecaster";

        public async Task<ForecastResult> GetAsync(PvForecastRequest request)
        {
            // TODO: Put into config
            string modelUrl = "http://bb1b2bd0-0430-490d-aab8-6cb3aaed5bc6.uksouth.azurecontainer.io/score";

            var response = await this.http.PostAsJsonAsync(modelUrl, request);

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            // Deserialise - the JSON we're getting back is a mess: unescape and drop first and last elements.
            var forecast = JsonSerializer.Deserialize<ForecastResult>(Regex.Unescape(responseString)[1..^1]);

            return forecast;
        }
    }
}
