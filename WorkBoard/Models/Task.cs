using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkBoard.Models
{
    public class Task
    {
        public int user_id { get; set; }
        public int task_name{ get; set; }
        public string status { get; set; }
        public string description { get; set; }
        public string team { get; set; }
        public DateTime creation_date { get; set; }
        public DateTime deadline_date { get; set; }
        public DateTime modification_date { get; set; } 
    }
}
