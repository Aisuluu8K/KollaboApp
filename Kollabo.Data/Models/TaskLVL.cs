﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Kollabo.Data.Models
{
    [PrimaryKey(nameof(Id))]
    public class TaskLVL
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TaskID { get; set; }
        public List<UserTask> tasks { get; set; }
    }
}