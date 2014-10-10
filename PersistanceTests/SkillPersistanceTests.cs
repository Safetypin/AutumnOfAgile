using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microdesk.SkillPortal.DomainPersistance;
using Microdesk.SkillPortal.DomainModel;
using NUnit.Framework;
using Rhino.Commons;

namespace PersistanceTests
{
    [TestFixture]
    public class SkillPersistanceTests : RepositoryPersistanceTestBase
    {
        [Test]
        public void CanGetListOfSkills()
        {
            SkillRepository skillRepos = new SkillRepository();
            using (UnitOfWork.Start())
            {
                IList<Skill> skills = skillRepos.GetAllSkills();
                Assert.Greater(skills.Count, 0);
            }
        }
    }
}
