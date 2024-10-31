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
        public async Task<int> FeedbackSearch(Feedback SearchFeedback)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@UserID", SearchFeedback.UserId));
            return await _dbContext.Database.ExecuteSqlRawAsync("exec spFeedbackGetByUserID @UserID", parameter.ToArray());
        }
    }
}
