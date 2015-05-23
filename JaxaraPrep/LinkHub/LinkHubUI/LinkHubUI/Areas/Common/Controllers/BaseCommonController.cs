using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace LinkHubUI.Areas.Common.Controllers
{
    public class BaseCommonController : Controller
    {
        protected CommonBs aCommonBs;
        public BaseCommonController()
        {
            aCommonBs = new CommonBs();
        }
    }
}