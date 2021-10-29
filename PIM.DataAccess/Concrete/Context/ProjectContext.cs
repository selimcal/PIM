using Microsoft.EntityFrameworkCore;
using PIM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
