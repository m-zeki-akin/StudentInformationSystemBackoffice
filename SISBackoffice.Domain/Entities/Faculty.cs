namespace SISBackoffice.Domain.Entities;

public class Faculty
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = null!;
    public virtual ICollection<Department> Departments { get; set; } = new HashSet<Department>();
}