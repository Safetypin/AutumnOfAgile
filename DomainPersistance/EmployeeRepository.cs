using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microdesk.SkillPortal.DomainModel;

namespace Microdesk.SkillPortal.DomainPersistance
{
    public class EmployeeRepository : Rhino.Commons.NHRepository<Employee>
    {

        public virtual Employee GetEmployee(Guid Id)
        {
            return base.Get(Id);
        }
    }
}
