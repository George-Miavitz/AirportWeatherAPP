using AirportWeatherAppAPI.Data;

namespace AirportWeatherAppAPI.DiegoSPRepositories
{
    public interface IAlertService
    {
        Task<int> AlertAdd(Alert NewAlert);
    }
}
