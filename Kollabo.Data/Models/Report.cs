using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace Kollabo.Data.Models
{
    public class Report
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        public List<UserTask> tasks { get; set; }
        public DateTime CreateDate { get; set; }
        public int statusID { get; set; }
        public Status status { get; set; }
    }
}