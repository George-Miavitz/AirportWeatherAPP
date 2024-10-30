using AirportWeatherAppAPI.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AirportWeatherAppAPI.DiegoSPRepositories
{
    public class ObservationService: IObservationService
    {
        private readonly DbContextClass _dbContext;
        public ObservationService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<int> ObservationDelete(Observation DeleteObservation)
        {
            var param = new SqlParameter("@ObservationID", DeleteObservation.ObservationID);
            return await _dbContext.Database.ExecuteSqlRawAsync("exec spObservationDelete @ObservationID", param);
        }
    }
}
