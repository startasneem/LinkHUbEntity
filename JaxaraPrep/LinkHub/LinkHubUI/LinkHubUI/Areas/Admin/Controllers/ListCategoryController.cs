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
    public class ListCategoryController : BaseAdminController
    {
        // GET: Admin/ListCategory
        public ActionResult Index(string sortOrder, string sortBy, string Page)
        {
            ViewBag.SortOrder = sortOrder;
            ViewBag.SortBy = sortBy;

            var categories = adminBs.Categorybs.GetCategories();

            //switch (sortBy)
            //{
            //    case "CategoryName":
            //        switch (sortOrder)
            //        {
            //            case "Asc":
            //                categories = categories.OrderBy(x => x.Name).ToList();
            //                break;
            //            case "Desc":
            //                categories = categories.OrderByDescending(x => x.Name).ToList();
            //                break;
            //            default:
            //                break;
            //        }
            //        break;
            //    case "CategoryDesc":
            //        switch (sortOrder)
            //        {
            //            case "Asc":
            //                categories = categories.OrderBy(x => x.Desc).ToList();
            //                break;
            //            case "Desc":
            //                categories = categories.OrderByDescending(x => x.Desc).ToList();
            //                break;
            //            default:
            //                break;
            //        }
            //        break;
            //    default:
            //        categories = categories.OrderBy(x => x.Name).ToList();
            //        break;
            //}

            //ViewBag.TotalPages = Math.Ceiling(adminBs.Categorybs.GetCategories().Count() / 10.0);
            //int page = int.Parse(Page == null ? "1" : Page);
            //ViewBag.Page = page;
            //categories = categories.Skip((page - 1) * 10).Take(10);
            return View(categories);
        }
    }
}