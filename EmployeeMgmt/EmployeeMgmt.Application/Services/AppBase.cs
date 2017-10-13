using EmployeeMgmt.Application.Contracts;
using EmployeeMgmt.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMgmt.Application.Services
{
    public abstract class AppBase<TEntity> : IAppBase<TEntity>
        where TEntity : class
    {
        private IDomainServiceBase<TEntity> domain;

        public AppBase(IDomainServiceBase<TEntity> domain)
        {
            this.domain = domain;
        }

        public void Create(TEntity obj)
        {
            domain.Insert(obj);
        }

        public void Update(TEntity obj)
        {
            domain.Update(obj);
        }

        public void Delete(TEntity obj)
        {
            domain.Delete(obj);
        }

        public List<TEntity> GetAll()
        {
            return domain.FindAll();
        }

        public TEntity GetById(int id)
        {
            return domain.FindById(id);
        }
    }
}
