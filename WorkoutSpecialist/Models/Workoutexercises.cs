using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Workoutspecialist.Models
{
    public class Workoutexercises
    {
        [Key]
        public int WorkoutExcerciseId { get; set; }

        [ForeignKey(nameof(Workouts))]
        public int WorkoutId { get; set; }

        [ForeignKey(nameof(Exercises))]
        public int ExerciseId { get; set; }

        public int Sets { get; set; }

        public int Reps { get; set; }

        public float Weight { get; set; }

        public Workouts? Workout { get; set; }

        public Exercises? Exercise { get; set; }

    }
}
