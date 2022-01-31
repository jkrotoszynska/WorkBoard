using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkBoard.Models
{
    public class TasksContext : DbContext
    {
        public TasksContext(DbContextOptions<TasksContext> options) : base(options)
        {

        }
        public DbSet<Task> Countires { get; set; } // dokonaliśmy mapowania po kodzie (zamieniamy rekordy na obiekty)

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>().HasKey("task_id"); // wskazujemy klucz podstawowy encji
            modelBuilder.Entity<Task>().ToTable("tasks"); 
        }

    }
}
