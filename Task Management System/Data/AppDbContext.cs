
using Microsoft.EntityFrameworkCore;

namespace Task_Management_System.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Task_Management_System.Models.Entities.Task> Tasks { get; set; }
    }
}
