using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using Rhino.Commons;

namespace PersistanceTests
{
    public class RepositoryPersistanceTestBase :Microdesk.Utility.UnitTest.DatabaseUnitTestBase
    {
        [SetUp]
        public void _Setup()
        {
            base.DatabaseSetUp();
        }

        [TearDown]
        public void _TearDown()
        {
            base.DatabaseTearDown();
        }
        
        [TestFixtureSetUp]
        public void _TestFixtureSetup()
        {
            WindsorContainer container = new WindsorContainer();
            container.AddComponent<IUnitOfWorkFactory, NHibernateUnitOfWorkFactory>();
            //container.Register(Component.For<IUnitOfWorkFactory, NHibernateUnitOfWorkFactory>());
            IoC.Initialize(container);
            base.DatabaseFixtureSetUp();
        }

        [TestFixtureTearDown]
        public void _TestFixtureTearDown()
        {
            base.DatabaseFixtureTearDown();
        }
    }
}
