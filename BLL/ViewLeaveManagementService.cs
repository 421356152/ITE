using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using Webdiyer.WebControls.Mvc;

namespace BLL
{
    /// <summary>
    /// 主页请假单信息的服务
    /// </summary>
    public class ViewLeaveManagementService
    {
        DbFactory dbFactory = new DbFactory();
        /// <summary>
        /// 获取主页未审批的请假单信息
        /// </summary>
        /// <returns></returns>
        public IPagedList<ViewLeaveManagement> ViewLeaveList(int pageIndex, int pageSize,int roleId)
        {
            var mm = dbFactory.ViewLeaveManagementDbFactory.FirstOrDefault(a=>a.UserName=="李四");
            if (mm.Tutor == null)
            {
                var list = dbFactory.ViewLeaveManagementDbFactory.Where(a => a.LeaveStatusId == 6 && a.RoleId == roleId).OrderByDescending(a => a.StartDateTime).ToPagedList(pageIndex, pageSize);
                ViewLeaveManagement temp = new ViewLeaveManagement();
                for (int i = 0; i < list.Count; ++i)
                {
                    for (int j = 0; j < list.Count - i - 1; ++j)
                    {
                        if (list[j].StartDateTime == list[j + 1].StartDateTime)
                        {
                            if (list[j + 1].LeaveCategory == "紧急请假")
                            {
                                temp = list[j];
                                list[j] = list[j + 1];
                                list[j + 1] = temp;
                            }
                        }
                    }
                }
                return list;
            }
            else
            {
                var list = dbFactory.ViewLeaveManagementDbFactory.Where(a => a.LeaveStatusId == 6 && a.RoleId == roleId|| a.LeaveStatusId == 8 && a.RoleId == roleId).OrderByDescending(a => a.StartDateTime).ToPagedList(pageIndex, pageSize);
                ViewLeaveManagement temp = new ViewLeaveManagement();
                for (int i = 0; i < list.Count; ++i)
                {
                    for (int j = 0; j < list.Count - i - 1; ++j)
                    {
                        if (list[j].StartDateTime == list[j + 1].StartDateTime)
                        {
                            if (list[j + 1].LeaveCategory == "紧急请假")
                            {
                                temp = list[j];
                                list[j] = list[j + 1];
                                list[j + 1] = temp;
                            }
                        }
                    }
                }
                return list;
            }
           
            

        }
        /// <summary>
        /// 获取主页已审批的请假单信息
        /// </summary>
        /// <returns></returns>
        public IPagedList<ViewLeaveManagement> OverViewLeaveList(int pageIndex, int pageSize, int roleId)
        {
            var mm = dbFactory.ViewLeaveManagementDbFactory.FirstOrDefault(a => a.UserName == "李四");
            if (mm.Tutor == null)
            {
                return dbFactory.ViewLeaveManagementDbFactory.Where(a => a.LeaveStatusId != 6 && a.RoleId == 1).OrderByDescending(a => a.StartDateTime).ToPagedList(pageIndex, pageSize);
            }
            else { return dbFactory.ViewLeaveManagementDbFactory.Where(a => a.LeaveStatusId != 6 && a.RoleId == 1|| a.LeaveStatusId != 8 && a.RoleId == 1).OrderByDescending(a => a.StartDateTime).ToPagedList(pageIndex, pageSize); }
        }
        /// <summary>
        /// 撤销请假单
        /// </summary>
        /// <param name="id">请假单ID</param>
        /// <returns></returns>
        public bool LeaveDel(int id)
        {
            var dmess = dbFactory.ViewLeaveManagementDbFactory;
            var mess = dbFactory.ViewLeaveManagementDbFactory.FirstOrDefault(a => a.LeaveStatusId == id);
            if (mess != null) {dmess.Remove(mess); return true; } else { return false; }
                
        }
    }
}
