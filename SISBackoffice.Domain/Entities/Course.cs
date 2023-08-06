namespace SISBackoffice.Domain.Entities;

public class Course
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = null!;
    public ICollection<InstructorCourse> InstructorCourses { get; set; } = new HashSet<InstructorCourse>();
    public Guid DepartmentId { get; set; } // Foreign key
    public virtual Department Department { get; set; } = null!; // Navigation property
    public byte Credit { get; set; }
    public byte Semester { get; set; }
    public float HoursPerWeek { get; set; }
    public virtual ICollection<Student> EnrolledStudents { get; set; } = new HashSet<Student>();
    public short MaxEnrollment { get; set; }
}