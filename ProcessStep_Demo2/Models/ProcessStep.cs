using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessStep_Demo2.Models
{
    [Table("ProcessSteps", Schema = "dbo")]
    public class ProcessStep
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int StepID { get; set; }
        [StringLength(50)]
        [Required]
        public string StepName { get; set; }
        [StringLength(250)]
        [Required]
        public string Description { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public DateTime? LastUpdated { get; set; }
        public int? LastUpdatedBy { get; set; }

    }
}
