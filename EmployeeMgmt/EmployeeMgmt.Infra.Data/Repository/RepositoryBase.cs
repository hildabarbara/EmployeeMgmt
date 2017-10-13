using EmployeeMgmt.Domain.Contracts.Repository;
using EmployeeMgmt.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMgmt.Infra.Data.Repository
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
        where TEntity : class
    {
        protected DataContext Con;

        public RepositoryBase()
        {
            Con = new DataContext();
        }

        public void Insert(TEntity obj)
        {
            Con.Entry(obj).State = EntityState.Added;
            Con.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            Con.Entry(obj).State = EntityState.Modified;
            Con.SaveChanges();
        }

        public void Delete(TEntity obj)
        {
            Con.Entry(obj).State = EntityState.Deleted;
            Con.SaveChanges();
        }

        public List<TEntity> FindAll()
        {
            return Con.Set<TEntity>().ToList();
        }

        public TEntity FindById(int id)
        {
            return Con.Set<TEntity>().Find(id);
        }


    }
}
