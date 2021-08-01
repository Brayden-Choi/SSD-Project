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


        [RegularExpression(@"[a-zA-Z\s]*$",
        ErrorMessage = "Please enter a valid text")]
        //[Required]
        [StringLength(200)]
        [Display(Name = "Feedback")]

        public string FeedbackText { get; set; }
    }
}
