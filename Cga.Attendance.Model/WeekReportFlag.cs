using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cga.Attendance.Model
{
    public class WeekReportFlag
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 周数 (第几周   周报开始写为第1周)
        /// </summary>
        [DefaultValue(0)]
        public int Flag { get; set; }
        /// <summary>
        /// 本周开始时间
        /// </summary>
        public string WeekStart { get; set; }
        /// <summary>
        /// 本周结束时间
        /// </summary>
        public string WeekEnd { get; set; }
        /// <summary>
        /// 每周的日期范围
        /// </summary>
        public string WeekRange { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
    }
}
