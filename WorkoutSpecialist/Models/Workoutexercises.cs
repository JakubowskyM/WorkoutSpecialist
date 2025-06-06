using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Workoutspecialist.Models
{
    public class Workoutexercises
    {
        [Key]
        public int WorkoutExerciseId { get; set; }

        [ForeignKey(nameof(Workout))]
        public int WorkoutId { get; set; }

        [ForeignKey(nameof(Exercise))]
        public int ExerciseId { get; set; }

        public int Sets { get; set; }
        public int Reps { get; set; }
        public float Weight { get; set; }

        public Workouts? Workout { get; set; }
        public Exercises? Exercise { get; set; }

    }
}
