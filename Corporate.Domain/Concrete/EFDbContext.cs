using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corporate.Domain.Entities;
using System.Data.Entity;
//using Corporate.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Corporate.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        //public EFDbContext() : base("EFDbContext")
        //{
        //}

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        //public DbSet<Department> Departments { get; set; }
        //public DbSet<Enrollment> Enrollments { get; set; }
        //public DbSet<Instructor> Instructors { get; set; }
        //public DbSet<Student> Students { get; set; }
        //public DbSet<OfficeAssignment> OfficeAssignments { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        //    modelBuilder.Entity<Category>()
        //        .HasMany(c => c.Products).WithMany(i => i.Categories);
        //        //.Map(t => t.MapLeftKey("CourseID")
        //        //    .MapRightKey("InstructorID")
        //        //    .ToTable("CourseInstructor"));
        //}

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
    }
}
