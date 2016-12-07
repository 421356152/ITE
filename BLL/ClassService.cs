using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class ClassService
    {
        DbFactory dbFactory = new DbFactory();
        /// <summary>
        /// 获取班级的数据列表
        /// </summary>
        /// <returns></returns>
        public List<Class> GetClass()
        {
            return dbFactory.ClassDbFactory.ToList();
        }
    }
}
