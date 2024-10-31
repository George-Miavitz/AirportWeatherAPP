using AirportWeatherAppAPI.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace AirportWeatherAppAPI.TaylorSPRepositories
{
    public class GetFeedbackByUserID : IGetFeedbackByUserID
    {
        private readonly DbContextClass _dbContext;

        public GetFeedbackByUserID(DbContextClass dbContext)
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
