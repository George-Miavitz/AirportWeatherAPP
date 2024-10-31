using AirportWeatherAppAPI.Data;

namespace AirportWeatherAppAPI.ShearerSPRepositories
{
    public interface IWeatherOrgAddClass
    {
        Task<int> WeatherOrgAdd(WeatherDataOrg OrgId);
    }
}
