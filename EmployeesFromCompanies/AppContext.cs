using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EmployeesFromCompanies
{
    public class AppContext: DbContext
    {
        public AppContext() : base("DefaultConnection")
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
