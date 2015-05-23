using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace LinkHubUI.Areas.Security.Controllers
{
    public class BaseSecurityController : Controller
    {
        protected SecurityBs aSecurityBs;

        public BaseSecurityController()
        {
            aSecurityBs= new SecurityBs();
        }
    }
}