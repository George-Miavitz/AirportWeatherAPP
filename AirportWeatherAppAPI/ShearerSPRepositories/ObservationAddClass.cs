using AirportWeatherAppAPI.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AirportWeatherAppAPI.ShearerSPRepositories
{
    public class ObservationAddClass : IObservationAddClass
    {
        private readonly DbContextClass _dbContext;
        public ObservationAddClass(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<int> ObservationAdd(Observation observation)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@UserID", observation.UserId));
            parameter.Add(new SqlParameter("@OrgID", observation.OrgId));
            parameter.Add(new SqlParameter("@Descriptor", observation.Descriptor));
            parameter.Add(new SqlParameter("@Timestamp", observation.Timestamp));
            parameter.Add(new SqlParameter("@Temperature", observation.Temperature));
            parameter.Add(new SqlParameter("@WindSpeed", observation.WindSpeed));
            parameter.Add(new SqlParameter("@WindDirection", observation.WindDirection));
            parameter.Add(new SqlParameter("@Visibility", observation.Visibility));

            return await _dbContext.Database.ExecuteSqlRawAsync("exec spObservationAdd @UserId, @OrgId, @Descriptor, @Timestamp, @Temperature, @WindSpeed,@WindDirection, @Visibility", parameter);
        }
    }
}
