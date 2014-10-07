using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Microdesk.SkillPortal.DomainModel
{
    public class EmployeeMap :ClassMapping<Employee>
    {
        public EmployeeMap()
        {
            Table("Employees");
            //Id(x => x.Id, m => m.Generator(Generators.Guid));

        }
    }
}
