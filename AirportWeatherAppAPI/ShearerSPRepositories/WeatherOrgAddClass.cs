/*using AirportWeatherAppAPI.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AirportWeatherAppAPI.ShearerSPRepositories
{
    public class WeatherOrgAddClass : IWeatherOrgAddClass
    {
        private readonly DbContextClass _dbContext;
        public WeatherOrgAddClass(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<int> WeatherOrgAdd(WeatherDataOrg OrgId)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@OrgName", OrgId.OrgName));
            return await _dbContext.Database.ExecuteSqlRawAsync("exec spWeatherOrgAdd @OrgID", parameter);
        }
    }
}
*/