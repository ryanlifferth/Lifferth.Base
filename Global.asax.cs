using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lifferth.Base
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Needed to allow for PartialViews subdirectory
            ViewEngines.Engines.Add(new RazorViewEngine
            {
                PartialViewLocationFormats = new string[]
                {
                    "~/Views/{1}/PartialViews/{0}.cshtml",
                    "~/Views/Shared/PartialViews/{0}.cshtml"
                }
            });
        }
    }
}
