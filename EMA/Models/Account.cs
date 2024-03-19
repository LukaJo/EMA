using System.ComponentModel.DataAnnotations;

namespace EMA.Models
{
    public class Account
    {
        [Required]
        public string? Matricola { get; set; }
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
        [Key]
        [EmailAddress]
        public string? Email { get; set; }
        public bool IsActive { get; set; } = false;

    }
}
