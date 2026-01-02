namespace AIEducationPlatform.Domain.Entities;

public class Section
{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;

    public Guid CourseId { get; set; }
    public Course Course { get; set; } = null!;
}
