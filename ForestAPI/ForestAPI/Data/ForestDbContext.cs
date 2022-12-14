using ForestAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ForestAPI.Data
{
    public class ForestDbContext : DbContext
    {
        public ForestDbContext(DbContextOptions<ForestDbContext>options)
            :base(options)
        {
        }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
