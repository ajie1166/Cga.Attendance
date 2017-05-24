using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cga.Attendance.Model
{
    /// <summary>
    /// 原始数据
    /// </summary>
    public class OriginalRecord
    {
        public int Id { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        public string JobNum { get; set; }
        /// <summary>
        /// 打卡时间
        /// </summary>
        public DateTime? CheckTime { get; set; }
        /// <summary>
        /// 创建时间  同步时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

    }
}
