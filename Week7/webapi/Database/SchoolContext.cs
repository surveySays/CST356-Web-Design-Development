using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class School : DbContext
    {
        public School(DbContextOptions<School> options) : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
        //public DbSet<Instructor> Instructor { get; set; }
    }
}