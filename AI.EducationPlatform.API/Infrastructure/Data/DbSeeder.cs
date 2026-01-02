using AI.EducationPlatform.Domain.Entities;
using AIEducationPlatform.Domain.Entities;
using AIEducationPlatform.Infrastructure.Data;

namespace AI.EducationPlatform.Infrastructure.Data;

public static class DbSeeder
{
    public static void Seed(AppDbContext context)
    {
        if (context.Users.Any()) return;

        var admin = new User
        {
            Id = Guid.NewGuid(),
            FullName = "Admin User",
            Email = "admin@platform.com",
            PasswordHash = "123456",
            Role = "Admin"
        };

        context.Users.Add(admin);
        context.SaveChanges();
    }
}
