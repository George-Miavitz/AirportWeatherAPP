using AirportWeatherAppAPI.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace AirportWeatherAppAPI.Repositories
{
    public class UserNewEmail : IUserEmailUpdate
    {
        private readonly DbContextClass _dbContext;

        public UserNewEmail(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> UpdateEmail(User NewEmail)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@UserID", NewEmail.UserId));
            parameter.Add(new SqlParameter("@NewEmail", NewEmail.Email));
            return await _dbContext.Database.ExecuteSqlRawAsync("exec spUserEmailUpdate @UserID, @NewEmail", parameter.ToArray());
        }

    }
}
