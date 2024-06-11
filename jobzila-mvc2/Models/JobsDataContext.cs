using Microsoft.EntityFrameworkCore;

namespace jobzila_mvc2.Models
{
    public class JobsDataContext : DbContext
    {

        public JobsDataContext(DbContextOptions<JobsDataContext> options) : base(options) {
            Database.EnsureCreated();
        }

        public DbSet<Jobs> Jobs { get; set; }
    }
}
