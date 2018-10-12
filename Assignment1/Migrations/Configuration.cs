namespace Assignment1.Migrations
{
    using Assignment1.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Assignment1.Models.ApplicationDbContext context)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            context.Sales.AddOrUpdate(p => p.Id,
                    new Models.Sale() { Id = 1, Date = DateTime.Now, Customer = new Models.Customer(), Employee = new Models.Employee() });
            context.Customers.AddOrUpdate(p => p.Id,
                   new Models.Customer() { Id = 1, Name = "Customer", Email = "customer@assignment.com" });
            context.StoreLocations.AddOrUpdate(p => p.Id,
                   new Models.StoreLocation() { Id = 1, LocationName = "asiignmentStore" });
            context.Products.AddOrUpdate(p => p.Id,
                   new Models.Product() { Id = 1, Name = "Apple", Price = 5, Quantity = 6 });
            context.SaveChanges();



            ApplicationUser adminUser;

            if (!context.Users.Any(p => p.UserName == "admin@assignment.com"))
            {
                adminUser = new ApplicationUser();
                adminUser.Email = "admin@assignment.com";
                adminUser.UserName = "admin@assignment.com";
                userManager.Create(adminUser, "Password-1");
            }
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
