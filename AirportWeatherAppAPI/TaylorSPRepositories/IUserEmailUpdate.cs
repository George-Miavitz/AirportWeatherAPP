using AirportWeatherAppAPI.Data;

//Interface for UserEmailUpdate created by Taylor Miavitz
namespace AirportWeatherAppAPI.TaylorSPRepositories
{
    public interface IUserEmailUpdate
    {
        Task<int> UpdateEmail(int UserId, string Email);
    }
}
