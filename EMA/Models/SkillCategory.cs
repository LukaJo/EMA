using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMA.Models
{
    [Table("SkillCategory")]
    public class SkillCategory
    {
        [Column("Id")]
        [Required]
        public int SkillCategoryId { get; set; }
        public string? CreatedBy { get; set; } 
        [Required]
        public DateTime CreatedDate { get; set; }
        public string? Description { get; set; } 
        [Required]
        public bool IsActive { get; set; }
        public string? ModifiedBy { get; set; } 
        public DateTime ModifiedDate { get; set; }
        [Required]
        public int Ordering { get; set; }
        [Required]
        public string? Value { get; set; }

        public List<SkillType> SkillTypes;
    }
}
