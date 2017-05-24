using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cga.Attendance.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ArrangeDate
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 所排的日期  哪一天
        /// </summary>
        public DateTime ArrangedDate { get; set; }
        /// <summary>
        /// 排班类型(0公休;1常日班)
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
    }
}
