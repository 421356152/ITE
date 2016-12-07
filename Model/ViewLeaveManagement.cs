using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    /// <summary>
    /// 视图(表Class-表userinfo-表LeaveRequest-表SystemCode的联合查询)，获取请假条的信息
    /// </summary>
    public class ViewLeaveManagement
    {
        [Key]
        /// <summary>
        /// 主键
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 请假单编号
        /// </summary>
        public string LeaveNo { get; set; }
        /// <summary>
        /// 班级名称
        /// </summary>
        public string ClassName { get; set; }
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartDateTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndDateTime { get; set; }
        /// <summary>
        /// 请假天数
        /// </summary>
        public decimal LeaveDays { get; set; }
        /// <summary>
        /// 请假单状态ID
        /// </summary>
        public int LeaveStatusId { get; set; }
        /// <summary>
        /// 请假单状态
        /// </summary>
        public string CodeDescription { get; set; }
        /// <summary>
        /// 请假类型
        /// </summary>
        public string LeaveCategory { get; set; }
        
        
    }
}
