using AIEducationPlatform.Application.DTOs;
using AIEducationPlatform.Domain.Entities;
using AIEducationPlatform.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AIEducationPlatform.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CoursesController : ControllerBase
{
    private readonly AppDbContext _context;

    public CoursesController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/courses
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var courses = await _context.Courses
            .Include(c => c.Instructor)
            .Select(c => new CourseDto
            {
                Id = c.Id,
                Title = c.Title,
                Description = c.Description,
                Price = c.Price,
                InstructorName = c.Instructor.FullName
            })
            .ToListAsync();

        return Ok(courses);
    }

    // POST: api/courses
    [HttpPost]
    public async Task<IActionResult> Create(CreateCourseDto dto)
    {
        var instructor = await _context.Users.FindAsync(dto.InstructorId);
        if (instructor == null)
            return BadRequest("Instructor not found");

        var course = new Course
        {
            Id = Guid.NewGuid(),
            Title = dto.Title,
            Description = dto.Description,
            Price = dto.Price,
            InstructorId = dto.InstructorId
        };

        _context.Courses.Add(course);
        await _context.SaveChangesAsync();

        return Ok(course.Id);
    }
}
