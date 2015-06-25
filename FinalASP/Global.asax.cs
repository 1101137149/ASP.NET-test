using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
<<<<<<< HEAD
=======
using System.Web.Optimization;
>>>>>>> e454fe1377f768192ee527504a60b9ceaff78cef
using System.Web.Routing;

namespace FinalASP
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
<<<<<<< HEAD
            RouteConfig.RegisterRoutes(RouteTable.Routes);
=======
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
>>>>>>> e454fe1377f768192ee527504a60b9ceaff78cef
        }
    }
}
