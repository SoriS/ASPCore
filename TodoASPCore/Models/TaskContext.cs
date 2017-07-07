using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TodoASPCore.Models
{
    public class TaskContext:DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=taskdb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public TaskContext(DbContextOptions<TaskContext> options ):base(options) { }       
    }
}
