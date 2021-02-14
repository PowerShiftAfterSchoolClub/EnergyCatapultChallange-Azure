using Energy.Catapult.Challenge.Azure.Functions.Domain.Model;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Energy.Catapult.Challenge.Azure.Functions.Domain.Forecasts
{
    class DemandForecaster : IForecaster<ForecastRequest, ForecastResult>
    {
        private readonly HttpClient http;

        public DemandForecaster(HttpClient http)
        {
            this.http = http ?? throw new ArgumentNullException(nameof(http));
        }

        public string Name => "Demand Forecaster";

        public async Task<ForecastResult> GetAsync(ForecastRequest request)
        {
            // TODO: Put into config
            string modelUrl = "http://06d43483-e30f-418c-90e4-f0a37c38453e.uksouth.azurecontainer.io/score";

            var response = await this.http.PostAsJsonAsync(modelUrl, request);

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            // Deserialise - the JSON we're getting back is a mess: unescape and drop first and last elements.
            var forecast = JsonSerializer.Deserialize<ForecastResult>(Regex.Unescape(responseString)[1..^1]);

            return forecast;
        }
    }
}
