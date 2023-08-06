
namespace SISBackoffice.Domain.Entities;

public class Executive
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string OfficeAddress { get; set; } = null!;
    public virtual ICollection<Department> Departments { get; set; } = null!; // Navigation property to the Faculty
}