using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MIST.Models
{
    public class Feedback
    {
        [Key]
        [Display(Name = "Feedback ID")]
        public int FeedbackId { get; set; }

        [ForeignKey("ApplicationUser")]
        [Display(Name = "User ID")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

       //[Required]
        [Display(Name = "Feedback")]
        public string FeedbackText { get; set; }
    }
}
