using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Microdesk.SkillPortal.DomainModel;
using Microdesk.SkillPortal.DomainPersistance;

using Rhino.Commons;

namespace PersistanceTests
{
    [TestFixture]
    public class EmployeePersistanceTests : RepositoryPersistanceTestBase
    {
        [Test]
        public void CanGetEmployeeById()
        {
            Guid theGuid = new Guid("11111111-1111-1111-1111-111111111111");
            EmployeeRepository empRepos = new EmployeeRepository();
            using (UnitOfWork.Start())
            {
                Employee emp = empRepos.GetEmployee(theGuid);
                Assert.IsNotNull(emp);
                Assert.AreEqual(theGuid, emp.Id); 
            }            
        }

        [Test]
        public void CanSaveEmployee()
        {
            EmployeeRepository empRepos = new EmployeeRepository();
            int initialSkillCount;
            Guid theGuid = new Guid("11111111-1111-1111-1111-111111111111");
            using (UnitOfWork.Start())
            {
                Employee emp = empRepos.GetEmployee(theGuid);
                initialSkillCount = emp.Skills.Count;
                emp.AddSkill(new Skill());
                empRepos.Save(emp);
                UnitOfWork.Current.Flush();
            }

            using (UnitOfWork.Start())
            {
                Employee emp = empRepos.GetEmployee(theGuid);
                Assert.AreEqual(emp.Skills.Count, initialSkillCount + 1);
            }
        }

        
    }
}
