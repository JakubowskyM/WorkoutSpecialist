using Microsoft.EntityFrameworkCore;
using Workoutspecialist.Models;


namespace WorkoutSpecialist.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Users> users { get; set; }
        public DbSet<Exercises> exercises { get; set; }
        public DbSet<Workouts> workouts { get; set; }
        public DbSet<Workoutexercises> workoutExercises { get; set; }
    }
}
