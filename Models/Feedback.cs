using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MIST.Models
{
    public class Feedback
    {
        public int ID { get; set; }

        [ForeignKey("Customer")]
        public int CustRefID { get; set; }
        public Customer Customer { get; set; }
        public string FeedbackText { get; set; }
    }
}
