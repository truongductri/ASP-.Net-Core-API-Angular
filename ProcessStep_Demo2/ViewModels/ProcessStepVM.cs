using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessStep_Demo2.ViewModels
{
    public class ProcessStepVM
    {
        [Key]
        public int StepID { get; set; }
        [MaxLength(50)]
        [Required]
        [Display(Name = "Name")]
        public string StepName { get; set; }
        [MaxLength(250)]
        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Active")]
        public bool IsActive { get; set; }
        [Display(Name = "Last Updated")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime LastUpdated { get; set; }
        [Display(Name = "Last Update By")]
        public int? LastUpdatedBy { get; set; }
    }
}
