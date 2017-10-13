using EmployeeMgmt.Domain.Contracts.Repository;
using EmployeeMgmt.Domain.Contracts.Services;
using EmployeeMgmt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMgmt.Domain.Implementations
{
    public class DomainServiceEmployee : DomainServiceBase<Employee>, IDomainServiceEmployee
    {
        private IRepositoryEmployee repository;

        public DomainServiceEmployee(IRepositoryEmployee repository)
            : base(repository)
        {
            this.repository = repository; 
        }
    }
}
