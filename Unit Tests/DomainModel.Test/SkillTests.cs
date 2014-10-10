using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Microdesk.SkillPortal.DomainModel.Test
{
    [TestFixture]
    public class SkillTests
    {
        [Test]
        public void EmployeeIsAssignedToSkillWhenSkillAddedToEmployee()
        {
            Employee emp = new Employee();
            emp.AddSkill(new Skill());
            Assert.AreSame(emp, emp.Skills[0].Employee);
        }

        [Test]
        public void CanAddSkillTypeToSkill()
        {
            Skill skill = new Skill();
            skill.SkillType = new SkillType();

            Assert.IsNotNull(skill.SkillType);
        }
    }

}
