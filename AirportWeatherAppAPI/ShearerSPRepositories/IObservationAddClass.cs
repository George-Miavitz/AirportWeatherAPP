using AirportWeatherAppAPI.Data;

namespace AirportWeatherAppAPI.ShearerSPRepositories
{
    public interface IObservationAddClass
    {
        Task<int> ObservationAdd(Observation observation);
    }
}
