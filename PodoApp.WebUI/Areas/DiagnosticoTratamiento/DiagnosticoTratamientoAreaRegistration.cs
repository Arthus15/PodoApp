using System.Web.Mvc;

namespace PodoApp.WebUI.Areas.DiagnosticoTratamiento
{
    public class DiagnosticoTratamientoAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "DiagnosticoTratamiento";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "DiagnosticoTratamiento_default",
                "DiagnosticoTratamiento/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}