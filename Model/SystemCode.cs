using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SystemCode
    {
        /// <summary>
        /// 系统码Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 编码类型
        /// </summary>
        public string CodeType { get; set; }
        /// <summary>
        /// 编码值
        /// </summary>
        public string CodeValue { get; set; }
        /// <summary>
        /// 编码描述
        /// </summary>
        public string CodeDescription { get; set; }
        /// <summary>
        /// 激活状态
        /// </summary>
        public bool IsActive { get; set; }
    }
}
