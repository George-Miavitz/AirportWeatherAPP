using AirportWeatherAppAPI.Data;

namespace AirportWeatherAppAPI.PhillipSPRepositories
{
    public interface IDeleteOrgService
    {
        Task<int> DeleteOrg(int orgId);
    }
}
