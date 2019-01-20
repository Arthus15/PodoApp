using System.Web.Mvc;

namespace PodoApp.WebUI.Areas.PrimeraVisita
{
    public class PrimeraVisitaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "PrimeraVisita";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "PrimeraVisita_default",
                "PrimeraVisita/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}