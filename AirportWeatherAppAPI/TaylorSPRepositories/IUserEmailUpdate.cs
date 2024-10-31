using AirportWeatherAppAPI.Data;

namespace AirportWeatherAppAPI.TaylorSPRepositories
{
    public interface IUserEmailUpdate
    {
        Task<int> UpdateEmail(User EmailUpdate);
    }
}
