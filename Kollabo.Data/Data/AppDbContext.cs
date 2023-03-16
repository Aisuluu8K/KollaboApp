using Kollabo.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Kollabo.Data.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        DbSet<UserTask> UsersTasks { get; set; }
        DbSet<Report> Reports { get; set; }
        DbSet<Status> Statuses { get; set; }
        DbSet<TaskOfStatus> TaskOfStatuses { get; set; }
        DbSet<TaskLVL> TaskLVLs { get; set; }
        DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}