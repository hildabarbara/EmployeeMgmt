using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace EmployeeMgmt.Infra.Data.Context
{
    using EmployeeMgmt.Infra.Data.Configurations;
    using EmployeeMgmt.Domain.Entities;

    public class DataContext : DbContext
    {
        public DataContext()
            : base(ConfigurationManager.ConnectionStrings["database"].ConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeConfig());
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
