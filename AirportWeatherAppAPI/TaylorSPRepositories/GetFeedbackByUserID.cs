using AirportWeatherAppAPI.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

//Created by Taylor Miavitz
namespace AirportWeatherAppAPI.TaylorSPRepositories
{
    public class GetFeedbackByUserID : IGetFeedbackByUserID
    {
        private readonly DbContextClass _dbContext;

        public GetFeedbackByUserID(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        //Results in a task that prompts a user to enter a UserID to retrieve feedback submitted by a different user.
        public async Task<IEnumerable<Feedback>> FeedbackSearch(int UserID)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@UserID", UserID));
            var myResults =  await Task.Run(() => _dbContext.Feedback.FromSqlRaw("exec spFeedbackGetByUserID @UserID", parameter.ToArray()));
            return myResults;
        }
    }
}
