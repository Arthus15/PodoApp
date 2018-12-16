﻿using Autofac;
using Autofac.Integration.Mvc;
using PodoApp.Contracts.ServiceLibrary.Interfaces;
using PodoApp.DB.Infrastructure;
using PodoApp.DB.Infrastructure.Repositories;
using PodoApp.Impl.ServiceLibrary;
using PodoApp.Library.Repositories;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;


namespace PodoApp.WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //AutoFac Depency Injection

            var builder = new ContainerBuilder();       
            builder.Register(c => new HttpContextWrapper(HttpContext.Current) as HttpContextBase).As<HttpContextBase>().InstancePerLifetimeScope();
            RegisterRepositories(builder);
            RegisterServices(builder);
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            var container = builder.Build();

            // Set MVC DI resolver to use our Autofac container
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }

        #region Private Methods
        protected void RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterType<PacienteService>().As<IPacienteService>();
        }

        private void RegisterRepositories(ContainerBuilder builder)
        {
            builder.RegisterType<PodologiaContext>().InstancePerRequest();
            builder.RegisterType<PacienteRepository>().As<IPacienteRepository>();
        }
        #endregion
    }
}
