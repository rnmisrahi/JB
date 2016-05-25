namespace CarRental02.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CarRental02.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CarRental02.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            //var userStore = new UserStore<ApplicationUser>(context);
            //var userManager = new UserManager<ApplicationUser>(userStore);

            //AddRole(context, "JBAdmin");
            //AddRole(context, "Employee");

            //AddUser(context, "JBAdmin", "JBAdmin@gmail.com", "Admin");
            //AddUser(context, "JBEmployee1", "Employee1@gmail.com", "Employee");
            //AddUser(context, "JBEmployee2", "Employee2@gmail.com", "Employee");
            //AddUser(context, "JBEmployee3", "Employee3@gmail.com", "Employee");
        }

        private static void AddUser(ApplicationDbContext context, string userName, string email, string role)
        {
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);
            if (!context.Users.Any(u => u.UserName == userName))
            {
                var user = new ApplicationUser { UserName = userName, Email = email };
                IdentityResult result = userManager.Create(user, "Passw0rd!");
                userManager.AddToRole(user.Id, userName);
                context.SaveChanges();
            }
        }

        private static void AddRole(ApplicationDbContext context, String role)
        {
            if (context.Roles.Any(r => r.Name == role)){
                context.Roles.AddOrUpdate(r => r.Name, new IdentityRole { Name = role });
                context.SaveChanges();
            }
        }
    }
}
