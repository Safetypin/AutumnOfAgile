using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MbUnit.Framework;
using Microdesk.SkillPortal.DomainModel;

namespace Microdesk.SkillPortal.DomainModel.Test
{
    [TestFixture]
    public class EmployeeTests
    {
        [Test]
        public void CanCreateWithDefaultConstructor()
        {
            Employee e = new Employee();

            Assert.IsNotNull(e);
        }
    }
}
