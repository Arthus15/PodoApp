using Autofac;
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
            //builder.RegisterType<ApplicationUser>().As<IApplicationUser>();
            //builder.RegisterType<ApplicationDbContext>().As<IApplicationDbContext>();

            

            builder.Build();
        }
    }
}
