using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMgmt.Domain.Contracts.Repository
{
    using EmployeeMgmt.Domain.Entities;

    public interface IRepositoryEmployee : IRepositoryBase<Employee>
    {
        
    }
}
