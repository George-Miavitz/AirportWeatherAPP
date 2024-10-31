using AirportWeatherAppAPI.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AirportWeatherAppAPI.PhillipSPRepositories
{
    public class DeleteOrgService : IDeleteOrgService
    {
        private readonly DbContextClass _dbContext;
        public DeleteOrgService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> DeleteOrg(int orgId)
        {
            var param =  new SqlParameter("@orgId", orgId);
            return await _dbContext.Database.ExecuteSqlRawAsync("exec spWeatherDataOrgDelete @orgId", param);
        }
    }
}
