using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WorkBoard.Models
{
    public class Task
    {
        [Key]
        [Display(Name = "Task ID")]
        //[Required(ErrorMessage = "Enter task ID")]
        // [IntLength(4, MinimumLength = 1, ErrorMessage = "Id tasku nie powinno przekraczać 4 cyfr")]

        public int task_id { get; set; }

        [Display(Name = "User")]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [Display(Name = "User Mail")]
        public string user_mail { get; set; }

        [Display(Name = "User Ini")]
        public string user_ini { get; set; }

        [Display(Name = "Task name")]
        public string task_name{ get; set; }

        [Display(Name = "Status")]
        public string status { get; set; }

        [Display(Name = "Desc")]
        public string description { get; set; }

        [Display(Name = "Team")]
        public string team { get; set; }

        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0: dd-MM-yyyy}")]
        public DateTime creation_date { get; set; }

        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0: dd-MM-yyyy}")]
        public DateTime deadline_date { get; set; }

        [Display(Name = "Mod. Date")]
        [DisplayFormat(DataFormatString = "{0: dd-MM-yyyy}")]
        public DateTime modification_date { get; set; } 


    }
}
