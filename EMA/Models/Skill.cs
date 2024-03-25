using EMA.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMA.Models
{
    [Table("Skill")]
    public class Skill
    {
        [Column("Id")]
        [Required]
        public int SkillId { get; set; }
        [Required]
        public DateTime EmployeesOppinionUpdatedTime { get; set; }
        public DateTime ManagersOppinionUpdatedTime { get; set; }
        public string? SkillExperience { get; set; }
        [Required]
        public double SkillExperienceDuration { get; set; }
        public string? OtherSkillType { get; set; }
        public SkillLevel SkillLevelManagersOppinion { get; set; }
        [Required]
        public SkillLevel SkillLevelEmployeesOppinion { get; set; }

        [Required]
        public int SkillTypeId { get; set; }

        [ForeignKey(nameof(SkillTypeId))]
        public SkillType SkillType { get; set; }

        [Required]
        public int SkillAssessmentId { get; set; }

        [ForeignKey(nameof(SkillAssessmentId))]
        public SkillAssessment SkillAssessment { get; set; }
    }
}
