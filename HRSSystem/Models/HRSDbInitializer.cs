using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HRSSystem.Models
{
    public class HRSDbInitializer : DropCreateDatabaseAlways<HRSSystemContext>
    {
        protected override void Seed(HRSSystemContext context)
        {
            IList<Employee> defaultEmployees = new List<Employee>();

            defaultEmployees.Add(new Employee() { FirstName = "John", LastName = "Smith", EmployeeNumber="JSE" });
            defaultEmployees.Add(new Employee() { FirstName = "Paul", LastName = "John", EmployeeNumber = "PJE" });
            defaultEmployees.Add(new Employee() { FirstName = "Larry", LastName = "Miller", EmployeeNumber = "LME" });

            context.Employees.AddRange(defaultEmployees);

            base.Seed(context);
        }
    }
}