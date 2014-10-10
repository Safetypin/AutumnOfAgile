using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microdesk.SkillPortal.DomainModel;

namespace Microdesk.SkillPortal.DomainPersistance
{
    public class SkillRepository : Rhino.Commons.NHRepository<Skill>
    {
        public virtual IList<Skill> GetAllSkills()
        {
            //throw new NotImplementedException();
            return base.FindAll().ToList<Skill>();
        }
    }
}
