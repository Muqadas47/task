using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task.Models
{
    public class TaskView
    {
        
    public int TaskID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string AssignedTo { get; set; }
        public DateTime DueDate { get; set; }
    }
}
