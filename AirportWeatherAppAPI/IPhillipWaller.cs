using AirportWeatherAppAPI.Data;

namespace AirportWeatherAppAPI
{
    public interface IPhillipWaller
    {
        Task<int> UserAddGetByUsername(AirportWeatherApp User);
    }
}
