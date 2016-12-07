using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Class
    {
        /// <summary>
        /// 班级Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 班级编号
        /// </summary>
        public string ClassCode { get; set; }
        /// <summary>
        /// 班级名称
        /// </summary>
        public string ClassName { get; set; }
        /// <summary>
        /// 班主任
        /// </summary>
        public string Administrator { get; set; }
        /// <summary>
        /// 导师
        /// </summary>
        public string Tutor { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
        public string Description { get; set; }
    }
}
