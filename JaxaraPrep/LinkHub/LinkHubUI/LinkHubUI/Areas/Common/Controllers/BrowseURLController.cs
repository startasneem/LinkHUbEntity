using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using BLL;

namespace LinkHubUI.Areas.Common.Controllers
{
    [AllowAnonymous]
    public class BrowseURLController : BaseCommonController
    {
        

        // GET: Common/BrowseURL
        public ActionResult Index(string sortOrder, string sortBy,string Page)
        {
            ViewBag.sortOrder = sortOrder;
            ViewBag.sortBy = sortBy;

            var urls = aCommonBs.UrLBs.GetUrls().Where(x => x.IsApproved == "A");

            //switch (sortBy)
            //{
            //    case "Title":
            //        switch (sortOrder)
            //        {
            //            case "Asc":
            //                urls = urls.OrderBy(x => x.Title).ToList();
            //                break;
            //            case "Desc":
            //                urls = urls.OrderByDescending(x => x.Title).ToList();
            //                break;
            //            default:
            //                break;
            //        }
            //        break;

            //    case "Name":
            //        switch (sortOrder)
            //        {
            //            case "Asc":
            //                urls = urls.OrderBy(x => x.tbl_Category.Name).ToList();
            //                break;
            //            case "Desc":
            //                urls = urls.OrderByDescending(x => x.tbl_Category.Name).ToList();
            //                break;
            //            default:
            //                break; 
            //        }
            //        break;

            //    case "Url":
            //        switch (sortOrder)
            //        {
            //            case "Asc":
            //                urls = urls.OrderBy(x => x.url).ToList();
            //                break;
            //            case "Desc":
            //                urls = urls.OrderByDescending(x => x.url).ToList();
            //                break;
            //            default:
            //                break;    
            //        }
            //        break;

            //    case "UrlDesc":
            //        switch (sortOrder)
            //        {
            //            case "Asc":
            //                urls = urls.OrderBy(x => x.urlDesc).ToList();
            //                break;
            //            case "Desc":
            //                urls = urls.OrderByDescending(x => x.urlDesc).ToList();
            //                break;
            //            default:
            //                break;    
            //        }
            //        break;
            //    default:
            //        urls = urls.OrderBy(x => x.Title).ToList();
            //        break;
                   
            //}

            //ViewBag.TotalPages = Math.Ceiling(aCommonBs.UrLBs.GetUrls().Where(x => x.IsApproved == "A").Count()/10.0);
            //int page = int.Parse(Page == null ? "1" : Page);
            //ViewBag.Page = page;

            //urls = urls.Skip((page - 1)*10).Take(10);
            return View(urls);
        }
    }
}