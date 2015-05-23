using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace LinkHubUI.Areas.User.Controllers
{
    public class BaseUserController : Controller
    {
        protected UserAreaBs areaBs;

        public BaseUserController()
        {
            areaBs = new UserAreaBs();

        }

    }
}