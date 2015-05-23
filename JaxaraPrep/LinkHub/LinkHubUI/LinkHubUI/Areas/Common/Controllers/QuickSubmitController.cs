using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;

namespace LinkHubUI.Areas.Common.Controllers
{
    [AllowAnonymous]
    public class QuickSubmitController : BaseCommonController
    {
        // GET: Common/QuickSubmit
        public ActionResult Index()
        {
            ViewBag.c_id = new SelectList(aCommonBs.Categorybs.GetCategories().ToList(), "id", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(QuickSubmit aSubmit)
        {
            try
            {
                ModelState.Remove("aUser.Password");
                ModelState.Remove("aUser.ConfirmPassword");
                ModelState.Remove("aUrl.UrlDesc");
                if (ModelState.IsValid)
                {
                    aCommonBs.InsertQuickUrls(aSubmit);
                    TempData["Msg"] = "Created Succ";
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.c_id = new SelectList(aCommonBs.Categorybs.GetCategories().ToList(), "id", "Name");
                    return View("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["Msg"] = "Created failed:" + ex.Message;
                return RedirectToAction("Index");
            }

        }

    }
}