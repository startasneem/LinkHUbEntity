using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using BOL;

namespace LinkHubUI.Areas.User.Controllers
{
    [Authorize(Roles = "A,U")]
    public class URLController : BaseUserController
    {

        // GET: User/URL
        public ActionResult Index()
        {
            ViewBag.c_id = new SelectList(areaBs.Categorybs.GetCategories().ToList(), "id", "Name");
            //ViewBag.u_id = new SelectList(areaBs.UserBs.GetAllUsers().ToList(), "Id", "Email");
            return View();
        }

        [HttpPost]
        public ActionResult Create(tbl_Url objUrl)
        {

            try
            {
                objUrl.IsApproved = "P";
                objUrl.u_id = areaBs.UserBs.GetAllUsers().Where(x => x.Email == User.Identity.Name).FirstOrDefault().Id;

                if (ModelState.IsValid)
                {
                    areaBs.UrLBs.Insert(objUrl);
                    TempData["Msg"] = "created successfuly";
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.c_id = new SelectList(areaBs.Categorybs.GetCategories().ToList(), "id", "Name");
                    //ViewBag.u_id = new SelectList(areaBs.UserBs.GetAllUsers().ToList(), "Id", "Email");
                    return View("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["Msg"] = "holo na:" + ex.Message;
                return RedirectToAction("Index");
            }

        }
    }
}