namespace AIEducationPlatform.Domain.Entities;

public class Course
{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }

    public Guid InstructorId { get; set; }
    public User Instructor { get; set; } = null!;

    public ICollection<Section> Sections { get; set; } = new List<Section>();
    public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}
