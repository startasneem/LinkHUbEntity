using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using BOL;

namespace LinkHubUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "A")]
    public class CategoryController : BaseAdminController
    {
        // GET: Admin/Category
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tbl_Category aCategory)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    adminBs.Categorybs.Insert(aCategory);
                    TempData["Msg"] = "Created Successfully";
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["Msg"] = "Hoilo na:" +ex.Message;
                return RedirectToAction("Index");

            }
            //aCategorybs.Insert(aCategory);
            //return View();
        }
    }
}