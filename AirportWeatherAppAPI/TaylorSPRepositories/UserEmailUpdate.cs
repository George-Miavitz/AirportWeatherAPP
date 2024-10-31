using AirportWeatherAppAPI.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

//Created by Taylor Miavitz
namespace AirportWeatherAppAPI.TaylorSPRepositories
{
    public class UserEmailUpdate : IUserEmailUpdate
    {
        private readonly DbContextClass _dbContext;

        public UserEmailUpdate(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        // Prompts a user to enter a UserID in order to update a Users Email.
        //The will later be integrated to an account settings based task.
        public async Task<int> UpdateEmail(int UserId, string Email)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@UserID", UserId));
            parameter.Add(new SqlParameter("@NewEmail", Email));
            return await _dbContext.Database.ExecuteSqlRawAsync("exec spUserEmailUpdate @UserID, @NewEmail", parameter.ToArray());
        }

    }
}
