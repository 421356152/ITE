using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    /// <summary>
    /// 请假单信息（表LeaveRequest）
    /// </summary>
    public class LeaveRequest
    {
        [Key]
        public int Id { get; set; }
        public string LeaveNo { get; set; }
        public int UserInfoId { get; set;}
        public string PersonalPhone { get; set; }
        public string EmergencyPhone { get; set; }
        public DateTime StartDateTime { get; set;}
        public DateTime EndDateTime { get; set; }
        public decimal LeaveDays { get; set; }
        public string LeaveCause { get; set; }
        public string LeaveCategory { get; set; }
        public int LeaveStatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdateDateTime { get; set; }
    }
}
