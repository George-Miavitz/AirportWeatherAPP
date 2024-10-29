using AirportWeatherAppAPI.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AirportWeatherAppAPI.DiegoSPRepositories
{
    public class AlertService: IAlertService
    {
        private readonly DbContextClass _dbContext;
        public AlertService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> AlertAdd(Alert NewAlert)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@AlertId", NewAlert.AlertId));
            parameter.Add(new SqlParameter("@UserId", NewAlert.UserId));
            parameter.Add(new SqlParameter("@ObservationId", NewAlert.ObservationId));
            parameter.Add(new SqlParameter("@CommunicationText", NewAlert.CommunicationText));
            return await _dbContext.Database.ExecuteSqlRawAsync("exec spAlertAdd @AlertId, @UserId, @ObservationId, @CommunicationText", parameter.ToArray());
        }

    }
}
