using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microdesk.SkillPortal.DomainModel
{
    public class Employee
    {
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
            _skills.Add(skill);
        }

        
    }
}
