using AirportWeatherAppAPI.Data;

// Interface for AlertService created by Diego Reyes
namespace AirportWeatherAppAPI.DiegoSPRepositories
{
    public interface IAlertService
    {
        Task<int> AlertAdd(Alert NewAlert);
    }
}
