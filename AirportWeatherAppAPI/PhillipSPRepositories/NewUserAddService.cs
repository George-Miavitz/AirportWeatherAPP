using AirportWeatherAppAPI.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AirportWeatherAppAPI.PhillipSPRepositories
{
    public class NewUserAddService : INewUserAdd
    {
        private readonly DbContext _dbContext;
        public NewUserAddService(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<int> UserAdd(User NewUser)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@Username", NewUser.UserName));
            parameter.Add(new SqlParameter("@Email", NewUser.Email));
            parameter.Add(new SqlParameter("@Password", NewUser.Password))
            return await _dbContext.Database.ExecuteSqlRawAsync("exec spUserAdd @Username, @Email, @Password", parameter.ToArray());

        }
    }
}
