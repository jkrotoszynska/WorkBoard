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

        public DbSet<Task> Tasks { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>().HasKey("task_id");
            modelBuilder.Entity<Task>().ToTable("task");
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(t => t.Tasks)
                .WithOne(u => u.ApplicationUser)
                .HasForeignKey(t => t.ApplicationUserId);
        }

    }
}
