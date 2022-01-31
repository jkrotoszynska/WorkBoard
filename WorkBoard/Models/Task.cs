using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WorkBoard.Models
{
    public class Task
    {
        [Display(Name = "ID Tasku")]
        public int task_id { get; set; }

        [Display(Name = "ID Użytkownika")]
        public int user_id { get; set; }

        [Display(Name = "Nazwa")]
        public string task_name{ get; set; }

        [Display(Name = "Status")]
        public string status { get; set; }

        [Display(Name = "Opis")]
        public string description { get; set; }

        [Display(Name = "Zespół")]
        public string team { get; set; }

        [Display(Name = "Data rozpoczęcia")]
        [DisplayFormat(DataFormatString = "{0: dddd-MMMM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime creation_date { get; set; }

        [Display(Name = "Data zakończenia")]
        [DisplayFormat(DataFormatString = "{0: dddd-MMMM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime deadline_date { get; set; }

        [Display(Name = "Data modyfikacji")]
        [DisplayFormat(DataFormatString = "{0: dddd-MMMM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime modification_date { get; set; } 
    }
}
