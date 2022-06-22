using Microsoft.EntityFrameworkCore;
using ToDoList21.Models;

namespace ToDoList21.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
              : base(options)
        {

        }
        public DbSet<Problem> ProblemSet { get; set; }
    }
}
