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
        //Need To Retrieve a String Using the UserID (Not an int)
        public async Task<IEnumerable<Feedback>> FeedbackSearch(int SearchFeedback)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@UserID", SearchFeedback));
            var myResults =  await Task.Run(() => _dbContext.Feedback.FromSqlRaw("exec spFeedbackGetByUserID @UserID", parameter.ToArray()));
            return myResults;
        }
    }
}
