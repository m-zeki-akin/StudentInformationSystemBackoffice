
namespace SISBackoffice.Domain.Entities;

public class Student
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string StudentNumber { get; set; } = null!;
    public byte Credit { get; set; }
    public byte TotalCredit { get; set; }
    public float Gpa { get; set; }
    public Guid DepartmentId { get; set; } // Foreign key to link to the Department
    public virtual Department Department { get; set; } = null!; // Navigation property to the Department
    public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>(); 
    public virtual ICollection<InstructorCourse> InstructorCourses { get; set; } = new HashSet<InstructorCourse>(); 
}