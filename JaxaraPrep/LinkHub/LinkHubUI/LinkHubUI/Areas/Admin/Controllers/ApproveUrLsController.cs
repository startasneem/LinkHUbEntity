using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkHubUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "A")]
    public class ApproveUrLsController : BaseAdminController
    {
        // GET: Admin/ApproveURLs
        public ActionResult Index(string status)
        {
            ViewBag.Status = (status == null ? "P" : status);
            if (status == null)
            {
                var urls = adminBs.UrLBs.GetUrls().Where(x => x.IsApproved == "P").ToList();
                return View(urls);
            }
            else
            {
                var urls = adminBs.UrLBs.GetUrls().Where(x => x.IsApproved == status).ToList();
                return View(urls);
            }
        }

        public ActionResult Approve(int id)
        {
            try
            {
                var myUrl = adminBs.UrLBs.GetById(id);
                myUrl.IsApproved = "A";
                adminBs.UrLBs.Update(myUrl);
                TempData["Msg"] = "Approved Successfully";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Msg"] = "Approved Failed:"+ex.Message;
                return RedirectToAction("Index");
                
            }
        }

        public ActionResult Reject(int id)
        {
            try
            {
                var myUrl = adminBs.UrLBs.GetById(id);
                myUrl.IsApproved = "R";
                adminBs.UrLBs.Update(myUrl);
                TempData["Msg"] = "Rejected Successfully";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Msg"] = "Rejected Failed:"+ex.Message;
                return RedirectToAction("Index");
                
            }
           
        }
    }
}