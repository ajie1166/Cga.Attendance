using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cga.Attendance.Model
{
    public class WeekReport
    {/// <summary>
    /// 编号 主键
    /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        public string JobNum { get; set; }
        /// <summary>
        /// 模块
        /// </summary>
        public string WorkModule { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string WorkContent { get; set; }
        /// <summary>
        /// 完成时间
        /// </summary>
        public string FinishDate { get; set; }
        /// <summary>
        /// 工作进度
        /// </summary>
        public string WorkProgress { get; set; }
        /// <summary>
        /// 周数表Id 外键
        /// </summary>
        public int WeekReportFlagId { get; set; }
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
