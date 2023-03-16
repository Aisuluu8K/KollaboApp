using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Kollabo.Data.Models
{
    [PrimaryKey(nameof(Id))]
    public class UserTask
    {
        public Guid UserID { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime createDate { get; set; }
        public DateTime updateDate { get; set; }

        public int taskStatusID { get; set; }
        public StatusOfTask taskStatus { get; set; }
        public int reportID { get; set; }
        public Report? report { get; set; }
        public int lvlID { get; set; }
        public TaskLVL lvlName { get; set; }

    }
}