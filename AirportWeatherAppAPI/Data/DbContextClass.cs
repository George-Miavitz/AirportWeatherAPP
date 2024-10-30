using AirportWeatherAppAPI.Data;
using Microsoft.EntityFrameworkCore;
namespace AirportWeatherAppAPI.Data
{
    public class DbContextClass : DbContext
    {
        protected readonly IConfiguration Configuration;
        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<User> User { get; set; }
        public DbSet<Alert> Alert { get; set; }
        public DbSet<Observation> Observation { get; set; }

    }
}