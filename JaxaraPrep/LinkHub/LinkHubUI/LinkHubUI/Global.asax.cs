﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.Web.WebPages.OAuth;

namespace LinkHubUI
{
    public class OAuthConfig
    {
        public static void RegisterProviders()
        {
            OAuthWebSecurity.RegisterGoogleClient();
        }
    }

    public class MvcApplication : System.Web.HttpApplication
    {

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            GlobalFilters.Filters.Add(new AuthorizeAttribute());

            OAuthConfig.RegisterProviders();
        }
    }
}
