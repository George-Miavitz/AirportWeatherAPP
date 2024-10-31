using AirportWeatherAppAPI.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AirportWeatherAppAPI.ShearerSPRepositories
{
    public class ObservationAddClass : IObservationAdd
    {
        private readonly DbContextClass _dbContext;
        public ObservationAddClass(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<int> ObservationAdd(int ObservationId)
        {
            var parameter = new SqlParameter("@ObservationID", ObservationId);
            return await _dbContext.Database.ExecuteSqlRawAsync("exec spObservationAdd @ObservationID", parameter);
        }
    }
}
