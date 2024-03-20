using EMA.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMA.Models
{
    [Table("Account")]
    public class Account
    {
        [Required]
        public string? Matricola { get; set; }
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }

        [EmailAddress]
        [Required]
        [Key]
        public string? Email { get; set; }
        [Required]
        public bool IsActive { get; set; }

        [Required]
        public Role Role;

    }
}
