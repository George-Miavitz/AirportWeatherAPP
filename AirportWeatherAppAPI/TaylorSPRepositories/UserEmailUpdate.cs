using AirportWeatherAppAPI.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace AirportWeatherAppAPI.Repositories
{
    public class NewEmail : IUserEmailUpdate
    {
        private readonly DbContextClass _dbcontext;

        public NewEmail(DbContextClass dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<int> UpdateEmail(User NewEmail)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@UserID", User.UserId));,
            parameter.Add(new SqlParameter("@NewEmail", User.Email));
            return await _dbcontext.Database.ExecuteSqlRawAsync("exec spUserEmailUpdate @UserID, @NewEmail", parameter.ToArray());
        }

    }
}
