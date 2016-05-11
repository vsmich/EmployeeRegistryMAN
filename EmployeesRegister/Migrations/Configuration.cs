namespace EmployeesRegister.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EmployeesRegister.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeesRegister.DataAccessLayer.EmployeesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        //#######################  Seed   ####################################################
        protected override void Seed(EmployeesRegister.DataAccessLayer.EmployeesContext context)
        {
            context.Employees.AddOrUpdate(
                p => p.FirstName,
                new Employee { FirstName = "Andreas", LastName = "Carsbring", Salary = 30000, Position = "CTO", Department = "IT" },
                new Employee { FirstName = "Andreas", LastName = "Åström", Salary = 25000, Position = "CEO", Department = "Economy" }
            );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //context.People.AddOrUpdate(
            //p => p.FullName,
            //new Employee { FullName = "Andrew", LastName = "Peters",   },
            //new Employee { FullName = "Brice Lambson" },
            //new Employee { FullName = "Rowan Miller" }
            //);
            //
        }
    }
}
