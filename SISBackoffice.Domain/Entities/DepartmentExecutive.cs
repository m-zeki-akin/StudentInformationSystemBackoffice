namespace SISBackoffice.Domain.Entities;

public class DepartmentExecutive
{
    public Guid DepartmentId { get; set; }
    public virtual Department Department { get; set; } = null!;

    public Guid ExecutiveId { get; set; }
    public virtual Executive Executive { get; set; } = null!;
}