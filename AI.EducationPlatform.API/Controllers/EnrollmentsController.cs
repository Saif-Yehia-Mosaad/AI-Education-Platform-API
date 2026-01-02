using AIEducationPlatform.Domain.Entities;
using AIEducationPlatform.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace AI.EducationPlatform.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EnrollmentsController : ControllerBase
{
    private readonly AppDbContext _context;
    public EnrollmentsController(AppDbContext context) => _context = context;

    [HttpPost]
    public IActionResult Enroll(Guid userId, Guid courseId)
    {
        var enrollment = new Enrollment
        {
            Id = Guid.NewGuid(),
            UserId = userId,
            CourseId = courseId,
            Progress = 0
        };

        _context.Enrollments.Add(enrollment);
        _context.SaveChanges();
        return Ok(enrollment);
    }
}
