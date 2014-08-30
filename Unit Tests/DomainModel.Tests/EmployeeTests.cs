﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Microdesk.SkillPortal.DomainModel;


namespace Microdesk.SkillPortal.DomainModel.Tests
{
    [TestFixture]
    public class EmployeeTests
    {
        [Test]
        public void CanCreatEmployeeWithDefaultConstructor()
        {
            Employee emp = new Employee();
            Assert.IsNotNull(emp);
        }

        [Test]
        public void CanAddSkillToEmployee()
        {
            Employee emp = new Employee();
            emp.AddSkill(new Skill());
            Assert.IsNotNull(emp.Skills);
        }

        [Test]
        public void SkillPropertyIsReadOnly()
        {
            Employee emp = new Employee();
            emp.AddSkill(new Skill());
            IList<Skill> skills = emp.Skills;
            Assert.IsTrue(skills.IsReadOnly);
        }
    }
}