using System;
using System.Collections.Generic;

#nullable disable

namespace Energy.Captapult.Challenge.DataAccess
{
    public partial class Task
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
