using AirportWeatherAppAPI.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace AirportWeatherAppAPI.Repositories
{
    public class FeedbackService : IFeedbackService
    {
        private readonly DbContextClass _dbContext;

        public FeedbackService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<int> GetFeedbackFromUserID(User FeedbackRetrieve)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@UserID", FeedbackRetrieve.UserId));
            return await _dbContext.Database.ExecuteSqlRawAsync("exec spFeedbackGetByUserID @UserID", parameter.ToArray());
        }
    }
}
