using AirportWeatherAppAPI.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

// Created by Diego Reyes
namespace AirportWeatherAppAPI.DiegoSPRepositories
{
    public class ObservationService: IObservationService
    {
        private readonly DbContextClass _dbContext;
        public ObservationService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        // Results in a task that prompts a user to enter an ObservationID to delete that observation
        // Will later be integrated into the Observation page on web app
        public async Task<int> ObservationDelete(int ObservationId)
        {
            var param = new SqlParameter("@ObservationID", ObservationId);
            return await _dbContext.Database.ExecuteSqlRawAsync("exec spObservationDelete @ObservationID", param);
        }
    }
}
