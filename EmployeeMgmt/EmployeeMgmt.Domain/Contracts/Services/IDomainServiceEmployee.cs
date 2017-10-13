using EmployeeMgmt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMgmt.Domain.Contracts.Services
{
    public interface IDomainServiceEmployee : IDomainServiceBase<Employee>
    {
    }
}
