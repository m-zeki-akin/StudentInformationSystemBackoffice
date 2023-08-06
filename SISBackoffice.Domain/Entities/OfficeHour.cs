namespace SISBackoffice.Domain.Entities;

public class OfficeHour
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public IDictionary<DayOfWeek, List<TimeSlot>> TimeSlots { get; set; } = new Dictionary<DayOfWeek, List<TimeSlot>>();

    public Guid InstructorId { get; set; } // Foreign key to link to the Instructor
    public virtual Instructor Instructor { get; set; } = null!; // Navigation property to the Instructor
}

public class TimeSlot
{
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
}