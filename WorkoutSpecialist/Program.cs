using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WorkoutSpecialist.Data;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace WorkoutSpecialist
{
    internal static class Program
    {
        public static DbContextOptions<AppDbContext> DbOptions { get; private set; }

        [STAThread]
        static void Main()
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>();

            builder.UseMySql(
                GetConnectionString(),
                ServerVersion.AutoDetect(GetConnectionString())
            );

            DbOptions = builder.Options;

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        private static string GetConnectionString()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            return config.GetConnectionString("DefaultConnection");
        }
    }
}
