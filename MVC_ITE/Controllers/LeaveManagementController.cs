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
        /// <summary>
        /// 显示主页信息
        /// </summary>
        /// <returns></returns>
        
        
        public ActionResult LeaveManagement(int id = 1)
        {
            ViewLeaveManagementService viewleavelist = new ViewLeaveManagementService();
            //获取已审批的请假单数据
            var overList = viewleavelist.OverViewLeaveList();
            //获取未审批的请假单数据
            //var list = viewleavelist.ViewLeaveList();
            ViewData["overList"] = overList;
            //ViewData["list"] = list;
            //return View();
            int pageSize = 2;
            //判断是否为Ajax请求
            if (Request.IsAjaxRequest())
            {
                //加载用户列表分部视图
                return PartialView("testController/_AjaxUserList", viewleavelist.ViewLeaveList(id, pageSize));
            }
            //将数据返回到前台
            return View(viewleavelist.ViewLeaveList(id, pageSize));
        }
        

    }
}