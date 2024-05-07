using TaskManagerServer.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace TaskManagerServer.WebAPI.Middlewares;

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
                    UserName = "admin",
                    Email = "admin@admin.com",
                    FirstName = "Taner",
                    LastName = "Saydam",
                    EmailConfirmed = true
                };

                userManager.CreateAsync(user, "1").Wait();
            }
            else
            {
                AppUser? user = userManager.Users.FirstOrDefault();
                if (user is not null)
                {
                    user.isAdmin = true;
                    userManager.UpdateAsync(user).Wait();
                }
            }
        }
    }
}