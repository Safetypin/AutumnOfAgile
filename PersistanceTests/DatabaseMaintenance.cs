using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PersistanceTests
{
    [TestFixture]
    public class DatabaseMaintenance : Microdesk.Utility.UnitTest.DatabaseUnitTestBase
    {
        [Test]
        //[Ignore]
        public void Test()
        {
            NHibernate.Cfg.Configuration cfg = new NHibernate.Cfg.Configuration();
            cfg.Configure();
            NHibernate.Tool.hbm2ddl.SchemaExport schema = new NHibernate.Tool.hbm2ddl.SchemaExport(cfg);
            schema.Drop(false, true);
            schema.Create(false, true);
        }

        [Test]
        public void SaveTheTestDataFileFromDB()
        {
            base.SaveTestDatabase();
        }

        [Test]
        public void LoadTestDataintoDB()
        {
            base.LoadTestDatabase();
        }

    }
}
