using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }
    public DbSet<Student> Students { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Course> Course { get; set; }
    public DbSet<Department> Department { get; set; }
    public DbSet<Instructor> Instructor { get; set; }
    public DbSet<CourseAssignment> CourseAssignments { get; set; }
    public DbSet<OfficeAssignment> OfficeAssignment { get; set; }
}
