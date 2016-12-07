using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class SystemCodeService
    {
        DbFactory dbFactory = new DbFactory();
        /// <summary>
        /// 获取请假状态的列表
        /// </summary>
        /// <returns></returns>
        public List<SystemCode> GetLeaveStatus()
        {
            return dbFactory.SystemCodeDbFactory.Where(a => a.CodeType == "LeaveStatus").ToList();
        }
    }
}
