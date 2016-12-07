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
        public IPagedList<ViewLeaveManagement> ViewLeaveList(int pageIndex,int pageSize)
        {
            var list = dbFactory.ViewLeaveManagementDbFactory.Where(a => a.LeaveStatusId == 6).OrderByDescending(a => a.StartDateTime).ToPagedList(pageIndex,pageSize);
            ViewLeaveManagement temp =new ViewLeaveManagement() ;
            for (int i = 0; i < list.Count; ++i)
            {
                for (int j = 0; j < list.Count - i - 1; ++j)
                {
                    if (list[j].StartDateTime == list[j + 1].StartDateTime)
                    {
                        if (list[j+1].LeaveCategory == "紧急请假")
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
        /// <summary>
        /// 获取主页已审批的请假单信息
        /// </summary>
        /// <returns></returns>
        public List<ViewLeaveManagement> OverViewLeaveList()
        {
            return dbFactory.ViewLeaveManagementDbFactory.Where(a => a.LeaveStatusId != 6).OrderByDescending(a => a.StartDateTime).ToList();
        }
    }
}
