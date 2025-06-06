using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Workoutspecialist.Models
{
    public class Workouts
    {
        [Key]
        public int WorkoutId { get; set; }

        [ForeignKey(nameof(Users))]
        public int UserId { get; set; }

        public DateTime Date { get; set; }

        public string? Note { get; set; }

        public Users? User { get; set; }

        public ICollection<Workoutexercises> WorkoutExercises { get; set; } = new List<Workoutexercises>();
    }
}

