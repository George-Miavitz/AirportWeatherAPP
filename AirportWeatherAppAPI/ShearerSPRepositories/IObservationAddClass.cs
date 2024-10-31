using AirportWeatherAppAPI.Data;

namespace AirportWeatherAppAPI.ShearerSPRepositories
{
    public interface IObservationAdd
    {
        Task<int> ObservationAdd(int ObservationId);
    }
}
