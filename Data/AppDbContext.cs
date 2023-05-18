using EmployeeManagementSystem.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().Property(e=> e.Salary).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Employee>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<Employee>().Property(p => p.DepartmentId).IsRequired();
            modelBuilder.Entity<Department>().Property(p => p.DepartmentName).IsRequired();
        }

    }
}
