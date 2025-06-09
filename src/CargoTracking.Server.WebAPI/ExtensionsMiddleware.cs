using CargoTracking.Server.Domain.Users;
using Microsoft.AspNetCore.Identity;

namespace CargoTracking.Server.WebAPI;

public static class ExtensionsMiddleware
{
    public static void CreateFirstUser(WebApplication app)
    {
        using (var scoped = app.Services.CreateScope())
        {
            var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();

            if (!userManager.Users.Any(p => p.UserName == "admin"))
            {
                AppUser user = new()
                {
                    Id = Guid.Parse("dd2f3344-0cf8-4ffd-bf9e-d66bcd825c3f"),
                    UserName = "admin",
                    Email = "admin@admin.com",
                    FirstName = "Dogukan",
                    LastName = "Zorer",
                    EmailConfirmed = true,
                    CreateAt = DateTimeOffset.Now,
                };

                user.CreateUserId = user.Id;

                userManager.CreateAsync(user, "1").Wait();


            }
        }
    }
}
