namespace WebApplication1.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebApplication1.Models.ApplicationDbContext context)
        {
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);
            //pravljenje rola i dodeljivanje role admin i employee
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            var role = new IdentityRole();
            role.Name = "Admin";
            roleManager.Create(role);

            if (!context.Users.Any(t => t.UserName == "Admin@rentacar.com"))
            {
                var User = new ApplicationUser { UserName = "Admin@rentacar.com", Email = "Admin@rentacar.com" };
                userManager.Create(User, "passW0rd?");

                userManager.AddToRole(User.Id, "Admin");
                context.SaveChanges();
            }

            var role2 = new IdentityRole();
            role2.Name = "Guest";
            roleManager.Create(role2);
            context.SaveChanges();

        }
    }
}
