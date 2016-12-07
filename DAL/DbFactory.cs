using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model;

namespace DAL
{
    public class DbFactory:DbContext
    {
        public DbFactory()
            : base("DefaultConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //用户表与用户Model配置对应关系
            modelBuilder.Entity<UserInfo>().ToTable("UserInfo");
            //请假单信息视图
            modelBuilder.Entity<ViewLeaveManagement>().ToTable("LeaveManagement");
            //班级表与班级Model配置对应关系
            modelBuilder.Entity<Class>().ToTable("Class");
            //系统码表与系统码Model配置对应关系
            modelBuilder.Entity<SystemCode>().ToTable("SystemCode");
            base.OnModelCreating(modelBuilder);
        }
        /// <summary>
        /// 用户信息工厂
        /// </summary>
        public DbSet<UserInfo> UserInfoDbFactory { get; set; }
        /// <summary>
        /// 主页请假单信息工厂
        /// </summary>
        public DbSet<ViewLeaveManagement> ViewLeaveManagementDbFactory { get; set; }
        /// <summary>
        /// 班级工厂
        /// </summary>
        public DbSet<Class> ClassDbFactory { get; set; }
        /// <summary>
        /// 系统码工厂
        /// </summary>
        public DbSet<SystemCode> SystemCodeDbFactory { get; set; }
    }
}
