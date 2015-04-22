﻿using System;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using BootstrapSupport;
using GameStore.WebUI.Mappings;

namespace GameStore.WebUI
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Bundles

            // Mapper
            Mapping.MapInit();
            BootstrapBundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        void SessionStart(object sender, EventArgs e)
        {
            HttpContext.Current.Session.Add("__MyAppSession", string.Empty);
        }
    }
}