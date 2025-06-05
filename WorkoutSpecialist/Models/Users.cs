using System.ComponentModel.DataAnnotations;

namespace Workoutspecialist.Models
{
    public class Users
    {
        
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; } = null!;

        [Required]
        public string PasswordHash { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        public DateTime RegistrationDate { get; set; }
   
}
}
