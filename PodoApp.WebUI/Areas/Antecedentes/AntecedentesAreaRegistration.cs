﻿using System.Web.Mvc;

namespace PodoApp.WebUI.Areas.Antecedentes
{
    public class AntecedentesAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Antecedentes";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Antecedentes_default",
                "Antecedentes/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}