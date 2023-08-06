
namespace SISBackoffice.Domain.Entities;

public class Instructor
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string OfficeAddress { get; set; } = null!;
    public Guid DepartmentId { get; set; } // Foreign key to link to the Faculty
    public virtual Department Department { get; set; } = null!; // Navigation property to the Faculty
    public virtual ICollection<InstructorCourse> InstructorCourses { get; set; } = new HashSet<InstructorCourse>();
    public virtual ICollection<OfficeHour> OfficeHours { get; set; } = new HashSet<OfficeHour>();
}