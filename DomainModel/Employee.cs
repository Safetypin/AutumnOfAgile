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

        private IList<Skill> _skills = new List<Skill>();
        public IList<Skill> Skills
        {
            get
            {
                return _skills.ToList<Skill>().AsReadOnly();
            }

        }

        public void AddSkill(Skill skill)
        {
            skill.Employee = this;
            _skills.Add(skill);
        }
        
    }
}
