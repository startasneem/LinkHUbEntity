using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;

namespace LinkHubUI.Areas.Security.Controllers
{
    [AllowAnonymous]
    public class RegisterController : BaseSecurityController
    {
        // GET: Security/Register
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tbl_User aUser)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    aUser.Role = "U";
                    aSecurityBs.UserBs.Insert(aUser);
                    TempData["Msg"] = "Succesfully Created";
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["Msg"] = "Ekta jhamela Hoiyee gese:"+ex.Message;
                return RedirectToAction("Index");
            }
        }
    }
}