using System.Web.Mvc;

namespace PodoApp.WebUI.Areas.ListaPacientes
{
    public class ListaPacientesAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ListaPacientes";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ListaPacientes_default",
                "ListaPacientes_default",
                "ListaPacientes/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}