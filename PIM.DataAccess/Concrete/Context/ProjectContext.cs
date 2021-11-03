using Microsoft.EntityFrameworkCore;
using PIM.Entity.Concrete;

namespace PIM.DataAccess.Concrete.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {

        }

        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=PIMDB;UID=sa;PWD=1");
            //optionsBuilder.UseSqlServer("Server=.;Database=PIMDB;Trusted_Connection=True");
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }
    }
}
