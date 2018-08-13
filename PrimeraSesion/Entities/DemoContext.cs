using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class DemoContext: DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Person>().
            //    Property(s => s.SecretIdentityId).IsRequired();
            // base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost; Database=Demo2; Trusted_Connection=True;");
        }
    }
}