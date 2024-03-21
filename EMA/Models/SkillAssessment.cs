using EMA.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMA.Models
{
    [Table("SkillAssessment")]
    public class SkillAssessment
    {
        [Required]
        [Column("Id")]
        public int SkillAssessmentId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public bool IsActive { get; set; }

        public string? Note { get; set; }
 
        public string? Feedback { get; set; }
        [Required]
        public SkillAssessmentStatus SkillAssessmentStatus;

    }
}
