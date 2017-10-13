using EmployeeMgmt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMgmt.Application.Contracts
{
    public interface IAppEmployee : IAppBase<Employee>
    {
    }
}
