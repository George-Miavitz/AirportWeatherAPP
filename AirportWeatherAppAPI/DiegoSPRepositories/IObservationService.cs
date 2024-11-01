using AirportWeatherAppAPI.Data;

// Interface for ObservationService created by Diego Reyes
namespace AirportWeatherAppAPI.DiegoSPRepositories
{
    public interface IObservationService
    {
        Task<int> ObservationDelete(int ObservationId);
    }
}
