using ExpressiveAnnotations.Attributes;
using ExpressiveAnnotations.MvcUnobtrusive.Providers;
using ExpressiveAnnotations.MvcUnobtrusive.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebFormMVC
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AreaRegistration.RegisterAllAreas();
            RouteConfig2.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            BundleConfig2.RegisterBundles(BundleTable.Bundles);



            DataAnnotationsModelValidatorProvider.RegisterAdapter(typeof(RequiredIfAttribute), typeof(RequiredIfValidator));
            DataAnnotationsModelValidatorProvider.RegisterAdapter(typeof(AssertThatAttribute), typeof(AssertThatValidator));
            ModelValidatorProviders.Providers.Remove(ModelValidatorProviders.Providers .FirstOrDefault(x => x is DataAnnotationsModelValidatorProvider));
            ModelValidatorProviders.Providers.Add(new ExpressiveAnnotationsModelValidatorProvider());


        }
    }
}