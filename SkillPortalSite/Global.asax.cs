using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.SessionState;
using Castle.Windsor;
using Rhino.Commons;
using Rhino.Commons.HttpModules;

namespace SkillPortalSite
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : UnitOfWorkApplication
    {
        //protected void Application_Start()
        //{
        //    AreaRegistration.RegisterAllAreas();

        //    WebApiConfig.Register(GlobalConfiguration.Configuration);
        //    FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        //    RouteConfig.RegisterRoutes(RouteTable.Routes);
        //    BundleConfig.RegisterBundles(BundleTable.Bundles);
        //    AuthConfig.RegisterAuth();
        //}

        public override void Application_Start(object sender, EventArgs e)
        {
            base.Application_Start(sender, e);

            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();

            ControllerBuilder.Current.SetControllerFactory(typeof(RhinoIoCControllerFactory));
        }

        protected override IWindsorContainer CreateContainer(string windsorConfig)
        {
            IWindsorContainer container = new WindsorContainer();
            container.AddComponent<IUnitOfWorkFactory, NHibernateUnitOfWorkFactory>();
            //container.AddComponent<Controllers.HomeController, Controllers.HomeController>();
            //container.AddComponent<Controllers.AccountController, Controllers.AccountController>();

            System.Reflection.Assembly assy = new Controllers.HomeController().GetType().Assembly;

            foreach (Type type in assy.GetTypes())
            {
                if (typeof(IController).IsAssignableFrom(type) && !type.IsAbstract)
                {
                    container.AddComponent(type.Name.ToUpper(), type);
                }
            }

            return container;
        }

        public class RhinoIoCControllerFactory : IControllerFactory
        {

            public IController CreateController(RequestContext requestContext, string controllerName)
            {
                return IoC.Resolve<IController>((controllerName + "Controller").ToUpper());
            }

            public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
            {
                return SessionStateBehavior.Default;
                //throw new NotImplementedException();
            }

            public void ReleaseController(IController controller)
            {
                IoC.Container.Release(controller);
            }
        }
    }
}