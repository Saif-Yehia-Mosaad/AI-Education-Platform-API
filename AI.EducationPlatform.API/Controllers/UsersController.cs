using AIEducationPlatform.Domain.Entities;
using AIEducationPlatform.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace AI.EducationPlatform.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly AppDbContext _context;
    public UsersController(AppDbContext context) => _context = context;

    [HttpPost]
    public IActionResult Create(User user)
    {
        user.Id = Guid.NewGuid();
        _context.Users.Add(user);
        _context.SaveChanges();
        return Ok(user);
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_context.Users.ToList());
}
