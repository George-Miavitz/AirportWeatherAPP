using AirportWeatherAppAPI.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace AirportWeatherAppAPI.TaylorSPRepositories
{
    public class UserEmailUpdate : IUserEmailUpdate
    {
        private readonly DbContextClass _dbContext;

        public UserEmailUpdate(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> UpdateEmail(int UserId, string Email)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@UserID", UserId));
            parameter.Add(new SqlParameter("@NewEmail", Email));
            return await _dbContext.Database.ExecuteSqlRawAsync("exec spUserEmailUpdate @UserID, @NewEmail", parameter.ToArray());
        }

    }
}
