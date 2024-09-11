using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

public class TaskManagementDBContext : DbContext
{
    public TaskManagementDBContext() : base("name=TaskManagementDBContext")
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<TaskView> TaskViews { get; set; } // Add this line

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TaskView>()
            .HasKey(t => t.TaskID); // Specify TaskID as the primary key

        base.OnModelCreating(modelBuilder);
    }
}

public class User
{
    public int UserID { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public string Role { get; set; }
   
    public DateTime? SignupDate { get; internal set; }
    public bool IsBlocked { get; internal set; }
    public bool IsDeleted { get; internal set; }
}


public class TaskView
{
    [Key]
    public int TaskID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public string AssignedTo { get; set; }
    public DateTime DueDate { get; set; }
}
