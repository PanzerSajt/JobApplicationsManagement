using Microsoft.EntityFrameworkCore;

namespace JobApplicationsManagement
{
    public class JobapplicationsContext : DbContext
    {

        public DbSet<Employer> Employers { get; set; }

        public DbSet<JobApplication> JobApplications { get; set; }

        public DbSet<ApplicationEvent> ApplicationEvents { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "Data Source=jobApplications.db");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
