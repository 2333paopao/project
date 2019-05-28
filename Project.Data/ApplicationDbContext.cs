using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Project.Data.Mappings;
using Project.Data.Migrations;
using Project.Entities;

namespace Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=ApplicationDbContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>(true));
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new UserMap());

        }
    }
}
