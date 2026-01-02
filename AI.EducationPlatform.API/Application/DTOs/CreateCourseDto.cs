namespace AIEducationPlatform.Application.DTOs;

public class CreateCourseDto
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }
    public Guid InstructorId { get; set; }
}
