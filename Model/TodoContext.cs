using BlazorApp1.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Model
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoItem> todoItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                base.OnConfiguring(optionsBuilder);
                optionsBuilder.UseSqlite("Data Source = mdb.db");

            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().HasData(new List<TodoItem>{
             new TodoItem{ Description = "Complete all Coded Assignments", IsCompleted = false, Id = 1, DueDate = new DateTime(2024,04,30)},
             new TodoItem{ Description = "Appartment Rent", IsCompleted = true, Id = 2 },
             new TodoItem{ Description = "Clean My Room", IsCompleted = false, Id = 3 } 
            });

        }
    }
}
