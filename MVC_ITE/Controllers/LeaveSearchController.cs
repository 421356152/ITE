using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Model;

namespace MVC_ITE.Controllers
{
    public class LeaveSearchController : Controller
    {
        ClassService classService = new ClassService();
        //SystemCode systemSer
        // GET: LeaveSearch
        public ActionResult LeaveSearch()
        {
            GetClassData();
            ViewLeaveManagementService viewLeaveManagementService = new ViewLeaveManagementService();
            var data=viewLeaveManagementService.GetLeaveSearch();

            return View(data);
        }
        public ActionResult Search()
        {
            return View();
        }

        /// <summary>
        /// 获取班级到下拉列表显示
        /// </summary>
        public void GetClassData()
        {
            var classList = classService.GetClass();
            ViewData["ClassList"] = new SelectList(classList, "Id", "ClassName");
        }
        //public void GetSys
    }
}