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

        public string? Notes { get; set; }

        public Users? User { get; set; }
    }
}
