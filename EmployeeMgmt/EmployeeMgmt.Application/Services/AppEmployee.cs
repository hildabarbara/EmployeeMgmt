using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMgmt.Application.Services
{
    using EmployeeMgmt.Application.Contracts;
    using Domain.Contracts.Services;
    using EmployeeMgmt.Domain.Entities;

    public class AppEmployee : AppBase<Employee>, IAppEmployee
    {
        private IDomainServiceEmployee domain;

        public AppEmployee(IDomainServiceEmployee domain)
            : base(domain)
        {
            this.domain = domain;
        }
    }
}
