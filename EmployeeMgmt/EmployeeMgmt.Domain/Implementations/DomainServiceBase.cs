using EmployeeMgmt.Domain.Contracts.Repository;
using EmployeeMgmt.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMgmt.Domain.Implementations
{
    public class DomainServiceBase<TEntity> : IDomainServiceBase<TEntity>
        where TEntity : class
    {
        private IRepositoryBase<TEntity> repository;

        public DomainServiceBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }

        public void Insert(TEntity obj)
        {
            repository.Insert(obj);
        }

        public void Update(TEntity obj)
        {
            repository.Update(obj);
        }

        public void Delete(TEntity obj)
        {
            repository.Delete(obj);
        }

        public List<TEntity> FindAll()
        {
            return repository.FindAll();
        }

        public TEntity FindById(int id)
        {
            return repository.FindById(id);
        }
    }
}
