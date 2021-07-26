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
        public int FeedbackID { get; set; }

        [ForeignKey("AspNetUsers")]
        public int Id { get; set; }

        public ApplicationUser FullName { get; set; }
        public string FeedbackText { get; set; }
    }
}
