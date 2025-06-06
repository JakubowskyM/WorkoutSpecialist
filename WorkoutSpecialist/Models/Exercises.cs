using System.ComponentModel.DataAnnotations;

namespace Workoutspecialist.Models
{
    public class Exercises
    {
        [Key]
        public int ExerciseId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string MuscleGroup { get; set; } = null!;

        public ICollection<Workoutexercises> WorkoutExercises { get; set; } = new List<Workoutexercises>();
    }
}
