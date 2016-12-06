using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class UserInfoService
    {
        DbFactory dbFactory = new DbFactory();
        public List<UserInfo> GetUserInfo()
        {
            return dbFactory.UserInfoDbFactory.ToList();
        }
    }
}
