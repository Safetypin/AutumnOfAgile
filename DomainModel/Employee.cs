using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microdesk.SkillPortal.DomainModel
{
    public class Employee : Microdesk.Domain.Foundation.GuidIdentityPersistenceBase<Employee>
    {
        private Employee _employee;

        public Employee()
        {

        }

        public virtual Guid Id
        {
            get
            {
                return _persistenceId;
            }
        }

        private IList<Skill> _skills = new List<Skill>();
        public virtual IList<Skill> Skills
        {
            get
            {
                return _skills.ToList<Skill>().AsReadOnly();
            }

        }

        public virtual void AddSkill(Skill skill)
        {
            skill.Employee = this;
            _skills.Add(skill);
        }
        
        
    }
}
