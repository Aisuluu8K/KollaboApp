using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Kollabo.Data.Models
{
    public class UserTask
    {
        public Guid UserID { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public int TaskStatusID { get; set; }
        public StatusOfTask TaskStatus { get; set; }
        public int ReportID { get; set; }
        public Report? Report { get; set; }
        public int LvlID { get; set; }
        public TaskLVL LvlName { get; set; }

    }
}