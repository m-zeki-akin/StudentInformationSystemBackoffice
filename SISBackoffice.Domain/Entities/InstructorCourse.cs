namespace SISBackoffice.Domain.Entities;

public class InstructorCourse
{
    public Guid InstructorId { get; set; }
    public virtual Instructor Instructor { get; set; } = null!;

    public Guid CourseId { get; set; }
    public virtual Course Course { get; set; } = null!;
}