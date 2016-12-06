using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Model;

namespace MVC_ITE.Controllers
{
    public class LeaveManagementController : Controller
    {
        //
        // GET: /LeaveManagement/
        public ActionResult LeaveManagement()
        {
            UserInfoService userInfoService = new UserInfoService();
            var list = userInfoService.GetUserInfo();
            ViewData["list"] = list;
            return View();
        }
	}
}