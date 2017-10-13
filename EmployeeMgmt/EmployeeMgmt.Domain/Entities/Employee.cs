using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMgmt.Domain.Entities
{
    public class Employee
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Occupation { get; set; }
        public virtual string Email { get; set; }
        public virtual DateTime Birth { get; set; }        
    }
}
