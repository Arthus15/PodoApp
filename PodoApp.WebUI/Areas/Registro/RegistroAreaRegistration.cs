using System.Web.Mvc;

namespace PodoApp.WebUI.Areas.Registro
{
    public class RegistroAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Registro";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Registro_default",
                "Registro/{controller}/{action}/{id}",
                new { action = "Registro", id = UrlParameter.Optional }
            );
        }
    }
}