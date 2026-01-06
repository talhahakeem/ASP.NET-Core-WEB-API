using FirstApp.Data.Config;
using Microsoft.EntityFrameworkCore;

namespace FirstApp.Data
{
    public class CollegeDBContext:DbContext
    {
        public CollegeDBContext(DbContextOptions<CollegeDBContext> options):base(options)
        {
            
        }

        public IEnumerable<object> Students { get; internal set; }
        DbSet<Student> Student {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());

    
        }
    }

}
