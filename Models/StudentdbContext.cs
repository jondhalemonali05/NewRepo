using Microsoft.EntityFrameworkCore;

namespace tuesdaycrud.Models
{
    public class StudentdbContext:DbContext
    {
        public StudentdbContext(DbContextOptions<StudentdbContext> options) : base(options) { }
        public DbSet<Student>stud{ get; set; }
       
    }
}
