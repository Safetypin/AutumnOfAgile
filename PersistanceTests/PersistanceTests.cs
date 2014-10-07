using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PersistanceTests
{
    [TestFixture]
    public class PersistanceTests
    {
        [Test]
        public void Test()
        {
            NHibernate.Cfg.Configuration cfg = new NHibernate.Cfg.Configuration();
            cfg.Configure();
            NHibernate.Tool.hbm2ddl.SchemaExport schema = new NHibernate.Tool.hbm2ddl.SchemaExport(cfg);
            schema.Drop(false, true);
            schema.Create(false, true);
        }

    }
}
