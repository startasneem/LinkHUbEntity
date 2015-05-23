﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BOL;
using Microsoft.Web.WebPages.OAuth;

namespace LinkHubUI.Areas.Security.Controllers
{
    [AllowAnonymous]
    public class LoginController : BaseSecurityController
    {
        // GET: Security/Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SIgnIn(tbl_User aUser)
        {
            try
            {
                if (Membership.ValidateUser(aUser.Email, aUser.Password))
                {
                    FormsAuthentication.SetAuthCookie(aUser.Email, false);
                    return RedirectToAction("Index", "Home", new { area = "Common" });
                }
                else
                {
                    TempData["Msg"] = " Login Failed";
                    return RedirectToAction("Index");
                }

            }
            catch (Exception ex)
            {
                TempData["Msg"] = " Login Failed:" + ex.Message;
                return RedirectToAction("Index");

            }
        }

        public ActionResult ExternalLogin(string Provider)
        {
            OAuthWebSecurity.RequestAuthentication(Provider,Url.Action("ExternalLoginCallBack"));
            return RedirectToAction("Index", "Home", new {Area = "Common"});
        }

        public ActionResult ExternalLoginCallBack(string Provider)
        {
            var result = OAuthWebSecurity.VerifyAuthentication();
            if (result.IsSuccessful==false)
            {
                TempData["Msg"] = "Login Failed";
                return RedirectToAction("Index");
            }
            else
            {
                aSecurityBs.CreateUserIfNotExist(result.UserName);
                FormsAuthentication.SetAuthCookie(result.UserName,false);
                return RedirectToAction("Index", "Home", new {Area = "Common"});
            }
            return RedirectToAction("Index", "Home", new { Area = "Common" });
        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home", new { area = "Common" });
        }

       
    }
}