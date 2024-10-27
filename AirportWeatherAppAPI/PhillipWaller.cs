using AirportWeatherAppAPI.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Reflection.Metadata;

namespace AirportWeatherAppAPI
{
    public class PhillipWaller: IPhillipWaller
    {
        private readonly AirportWeatherAppContext _dbContext;
        public PhillipWaller(AirportWeatherAppContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> UserAddGetByUsername(int username)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@Username", User.Username));
            parameter.Add(new SqlParameter("@Email", User.Email));
            parameter.Add(new SqlParameter("@Password", User.Password));
            return await _dbContext.Database.ExecuteSqlRawAsync("exec spUserAdd @Username, @Email, @Password", Parameter.ToArray());
        }
    }
}
