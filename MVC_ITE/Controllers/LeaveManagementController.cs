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
        ViewLeaveManagementService viewleavelist = new ViewLeaveManagementService();
        public static int num=1;
        public ActionResult LeaveManagement(int id = 1,int mm=1)
        {
            
            int pageSize = 2;
            //获取已审批的请假单数据
            var overList = viewleavelist.OverViewLeaveList(mm, pageSize,1);
            //获取未审批的请假单数据
            //var list = viewleavelist.ViewLeaveList();
            ViewData["overList"] = overList;
            //ViewData["list"] = list;
            //return View();
            //判断是否为Ajax请求
            if (Request.IsAjaxRequest())
            {
                if (id == num)
                {
                    //加载用户列表分部视图
                    return PartialView("LeaveManagements/_PartialLeavePageOver", viewleavelist.OverViewLeaveList(mm, pageSize,1));
                    
                }
                else { num = id; return PartialView("LeaveManagements/_PartialLeavePage", viewleavelist.ViewLeaveList(id, pageSize,1));  }
            }
            //将数据返回到前台
            return View(viewleavelist.ViewLeaveList(id, pageSize,1));
        }
        
        /// <summary>
        /// 撤销请假单
        /// </summary>
        /// <returns></returns>
        public JsonResult Rescind(int id)
        {
            bool result = viewleavelist.LeaveDel(id);
            if (result)
        {
                return Json("成功");
            }
            else { return Json("失败");}
        }
        

	}
}