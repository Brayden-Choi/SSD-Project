using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MIST.Models
{
    public class AuditRecord
    {
        [Key]
        public int Audit_ID { get; set; }

        [Display(Name = "Audit Action")]
        public string AuditActionType { get; set; }
        // Could be Login Success /Failure/ Logout, Create, Delete, View, Update

        [Display(Name = "Performed By")]
        public string Username { get; set; }
        //Logged in user performing the action

        [Display(Name = "Date/Time Stamp")]
        [DataType(DataType.DateTime)]
        public DateTime DateTimeStamp { get; set; }
        //Time when event occurred

        [Display(Name = "Game Record ID")]
        public int KeyMovieFieldID { get; set; }
        //Store ID of movie record affected

        [Display(Name = "Role ID")]
        public string RoleID { get; set; }
        //Store string of role added

        [Display(Name = "Details")]
        public string Details { get; set; }
        //extra data
    }

}
