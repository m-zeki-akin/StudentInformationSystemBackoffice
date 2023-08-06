
namespace SISBackoffice.Domain.Entities;

public class Department
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = null!;
    public Guid FacultyId { get; set; } // Foreign key to link to the Faculty
    public virtual Faculty Faculty { get; set; } = null!; // Navigation property to the Faculty
    public virtual ICollection<Executive> Executives { get; set; } = new HashSet<Executive>();
    public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    public virtual ICollection<Instructor> Instructor { get; set; } = new HashSet<Instructor>();
}