using System.Threading.Tasks;

namespace Energy.Catapult.Challenge.Azure.Functions.Domain.Forecasts
{
    public interface IForecaster<TRequest, TResponse>
    {
        public string Name { get; }

        Task<TResponse> GetAsync(TRequest request);
    }
}
