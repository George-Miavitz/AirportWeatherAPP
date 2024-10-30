using AirportWeatherAppAPI.Data;

namespace AirportWeatherAppAPI.DiegoSPRepositories
{
    public interface IObservationService
    {
        Task<int> ObservationDelete(int ObservationID);
    }
}
