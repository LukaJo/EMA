using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EMA.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Required]
        public string? Matricola { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Lastname { get; set; }

        [EmailAddress]
        [Required]
        [Key]
        public string? Email { get; set; }
        public string? Telephone { get; set; }
        [Required]
        public bool IsActive { get; set; }

        [Required]
        public string? TechnicalManager { get; set; }

        public List<SkillAssessment> SkillAssessments;
    }
}
