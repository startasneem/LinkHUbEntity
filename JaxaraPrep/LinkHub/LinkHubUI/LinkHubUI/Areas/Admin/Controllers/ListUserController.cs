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
    public class ListUserController : BaseAdminController
    {
        // GET: Admin/ListUser
        public ActionResult Index(string SortOrder, string SortBy)
        {
            ViewBag.SortOrder = SortOrder;
            ViewBag.SortBy = SortBy;
            var users = adminBs.UserBs.GetAllUsers();


            //switch (SortBy)
            //{
            //    case "UserEmail":
            //        switch (SortOrder)
            //        {
            //            case "Asc":
            //                users = users.OrderBy(x => x.Email).ToList();
            //                break;
            //            case "Desc":
            //                users = users.OrderByDescending(x => x.Email).ToList();
            //                break;
            //            default:
            //                break;
            //        }
            //        break;

            //    case "Role":
            //        switch (SortOrder)
            //        {
            //            case "Asc":
            //                users = users.OrderBy(x => x.Role).ToList();
            //                break;
            //            case "Desc":
            //                users = users.OrderByDescending(x => x.Role).ToList();
            //                break;
            //            default:
            //                break;
            //        }
            //        break;
            //    default:
            //        users = users.OrderBy(x => x.Email).ToList();
            //        break;
            //}

            //ViewBag.TotalPage = Math.Ceiling(adminBs.UserBs.GetAllUsers().Count() / 10.0);
            //int page = int.Parse(Page == null ? "1" : Page);
            //ViewBag.Page = page;
            //users = users.Skip((page - 1)*10).Take(10);
            
            return View(users);

        }
    }
}