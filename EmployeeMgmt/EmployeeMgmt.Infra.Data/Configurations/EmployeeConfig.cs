using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EmployeeMgmt.Infra.Data.Configurations
{
    using EmployeeMgmt.Domain.Entities;

    public class EmployeeConfig : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfig()
        {
            ToTable("EMPLOYEE");

            HasKey(e => e.Id);

            Property(e => e.Id)
                .HasColumnName("IDEMPLOYEE")
                .IsRequired();

            Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(255)
                .IsRequired();

            Property(e => e.Occupation)
                .HasColumnName("OCCUPATION")
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Email)
                .HasColumnName("EMAIL")
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Birth)
                .HasColumnName("BIRTH")
                .IsRequired();
        }
    }
}
