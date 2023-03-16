using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace Kollabo.Data.Models
{
    [PrimaryKey(nameof(Id))]
    public class TaskOfStatus
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        public List<UserTask> tasks { get; set; }
    }
}