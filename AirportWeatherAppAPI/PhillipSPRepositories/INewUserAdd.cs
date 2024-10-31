using AirportWeatherAppAPI.Data;

namespace AirportWeatherAppAPI.PhillipSPRepositories
{
    public interface INewUserAdd
    {
        Task<int> UserAdd(User NewUser);
    }
}
