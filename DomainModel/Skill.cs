using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microdesk.SkillPortal.DomainModel
{
    public class Skill : Microdesk.Domain.Foundation.GuidIdentityPersistenceBase<Skill>
    {
        private Employee _employee;
        public virtual Employee Employee
        {
            get
            {
                return _employee;
            }
            set
            {
                _employee = value;
            }
        }

        private SkillType _skillType;
        public virtual SkillType SkillType
        {
            get
            {
                return _skillType;
            }
            set
            {
                _skillType = value;
            }
        }
    }
}
