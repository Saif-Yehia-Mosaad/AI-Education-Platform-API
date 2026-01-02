using AIEducationPlatform.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AIEducationPlatform.Domain.Entities;

namespace AI.EducationPlatform.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SectionsController : ControllerBase
{
    private readonly AppDbContext _context;

    public SectionsController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/Sections/course/{courseId}
    [HttpGet("course/{courseId}")]
    public IActionResult GetByCourse(Guid courseId)
    {
        var sections = _context.Sections
            .Where(s => s.CourseId == courseId)
            .ToList();

        return Ok(sections);
    }

    // POST: api/Sections
    [HttpPost]
    public IActionResult Create(Section section)
    {
        section.Id = Guid.NewGuid();
        _context.Sections.Add(section);
        _context.SaveChanges();

        return Ok(section);
    }
}
