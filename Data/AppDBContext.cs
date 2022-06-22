using Microsoft.EntityFrameworkCore;
using ToDoList21.Models;

namespace ToDoList21.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext()
              : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
         => options.UseSqlServer($"Server=(localdb)\\MSSQLLocalDB;Database=ProblemDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        public DbSet<Problem> ProblemSet { get; set; }
    }
}
