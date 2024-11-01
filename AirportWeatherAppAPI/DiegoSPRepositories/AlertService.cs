using AirportWeatherAppAPI.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

// Created by Diego Reyes
namespace AirportWeatherAppAPI.DiegoSPRepositories
{
    public class AlertService: IAlertService
    {
        private readonly DbContextClass _dbContext;
        public AlertService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        /* Results in a task that prompts a user to enter a UserID, ObservationID, and Communication Text
          to add an alert.*/
        // Will later be integrated into the Alert page on web app
        public async Task<int> AlertAdd(Alert NewAlert)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@UserId", NewAlert.UserId));
            parameter.Add(new SqlParameter("@ObservationID", NewAlert.ObservationId));
            parameter.Add(new SqlParameter("@CommunicationText", NewAlert.CommunicationText));
            return await _dbContext.Database.ExecuteSqlRawAsync("exec spAlertAdd @UserId, @ObservationId, @CommunicationText", parameter.ToArray());
        }

    }
}
